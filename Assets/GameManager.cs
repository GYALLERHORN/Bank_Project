using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject user;

    public GameObject exchangePanel;

    public TMP_Text userName;
    public TMP_Text userCash;
    public TMP_Text userAccount;

    public bool isDepositRunning;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        userName.text = user.GetComponent<UserInfo>().userName;
        userCash.text = user.GetComponent<UserInfo>().cash.ToString();
        userAccount.text = user.GetComponent<UserInfo>().account.ToString();
    }

    public void RunDepositPanel()
    {
        isDepositRunning = true;
        exchangePanel.SetActive(true);
    }


    public void Deposit(int money)
    {
        userCash.text = (int.Parse(userCash.text) - money).ToString();
        userAccount.text = (int.Parse(userAccount.text) + money).ToString();
    }

    public void Withdraw(int money)
    {
        userAccount.text = (int.Parse(userAccount.text) - money).ToString();
        userCash.text = (int.Parse(userCash.text) + money).ToString();
    }
}
