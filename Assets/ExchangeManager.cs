using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ExchangeManager : MonoBehaviour
{
    public GameObject User;

    [SerializeField] private GameObject inputField;
    private TMP_InputField _field;

    private void Awake()
    {
        _field = inputField.GetComponent<TMP_InputField>();
    }
    private void InputMoney()
    {
        GameObject clickedButton = EventSystem.current.currentSelectedGameObject;
        int money = int.Parse(clickedButton.GetComponentInChildren<TMP_Text>().text);

        AddMoney(money);
    }

    private void AddMoney(int money)
    {
        if (int.TryParse(_field.text, out int result))
        {
            _field.text = (int.Parse(_field.text) + money).ToString();
            // Debug.Log(_field.text);
        }
    }

    private void RequestExchange() // 우선 입금부터 Cash->Account
    {
        int moneyOnWaiting = int.Parse(_field.text);
        bool isAvailable = CheckAmountOf(moneyOnWaiting);
    }

    private bool CheckAmountOf(int moneyOnWaiting)
    {
        if (moneyOnWaiting > int.Parse(GameManager.instance.userCash.ToString()))
        {
            return false;
        }

        return true;
    }

    private void Cancel()
    {

    }
}
