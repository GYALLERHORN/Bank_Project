using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ExchangeManager : MonoBehaviour // 입금만을 처리하는 스크립트다.
{
    public GameObject User;
    public GameObject alertPanel;

    [SerializeField] private GameObject inputField;
    protected TMP_InputField _field;

    private void Awake()
    {
        _field = inputField.GetComponent<TMP_InputField>();
    }

    private void OnEnable()
    {
        _field.text = "0";
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

    public virtual void RequestExchange() // 우선 입금부터 Cash->Account
    {
        int moneyOnWaiting = int.Parse(_field.text);
        bool isAvailable = CheckAmountOf(moneyOnWaiting);
        if (isAvailable)
        {
            GameManager.instance.Deposit(moneyOnWaiting);
            _field.text = "0";
        }
        else
        {
            alertPanel.SetActive(true);
        }
    }

    protected virtual bool CheckAmountOf(int moneyOnWaiting)
    {
        if (moneyOnWaiting > int.Parse(GameManager.instance.userCash.text.Replace(",","")))
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
