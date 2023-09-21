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
    public GameObject alertPanel;

    [SerializeField] private GameObject inputField;
    private TMP_InputField _field;

    private void Awake()
    {
        _field = inputField.GetComponent<TMP_InputField>();
    }
    public void InputMoney()
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

    public void RequestExchange() // 우선 입금부터 Cash->Account
    {
        int moneyOnWaiting = int.Parse(_field.text);
        bool isAvailable = CheckAmountOf(moneyOnWaiting);
        if (isAvailable)
        {
            GameManager.instance.Deposit(moneyOnWaiting);
        }
        else
        {
            alertPanel.SetActive(true);
        }
    }

    private bool CheckAmountOf(int moneyOnWaiting)
    {
        if (moneyOnWaiting > int.Parse(GameManager.instance.userCash.text))
        {
            return false;
        }
        return true;
    }

    public void Cancel()
    {
        gameObject.SetActive(false);
    }
}
