using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ExchangeManager : MonoBehaviour // �Աݸ��� ó���ϴ� ��ũ��Ʈ��.
{
    public GameObject User;
    public GameObject alertPanel;

    [SerializeField] private GameObject inputField;
    protected TMP_InputField _field;

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

    public virtual void RequestExchange() // �켱 �Աݺ��� Cash->Account
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

    protected virtual bool CheckAmountOf(int moneyOnWaiting)
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
