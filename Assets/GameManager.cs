using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject user;

    public GameObject depositPanel;
    public GameObject withdrawPanel;

    public TMP_Text userName;
    public TMP_Text userCashText;
    public TMP_Text userAccountText;

    public bool isDepositRunning;

    private void Awake()
    {
        instance = this;

        userName.text = user.GetComponent<UserInfo>().userName;
        userCashText.text = user.GetComponent<UserInfo>().cash.ToString();
        userAccountText.text = user.GetComponent<UserInfo>().account.ToString();
    }

    public void RunDepositPanel()
    {
        isDepositRunning = true;
        depositPanel.SetActive(true);
    }

    public void RunWithdrawPanel()
    {
        isDepositRunning = false;
        withdrawPanel.SetActive(true);
    }


    public void Deposit(int money)
    {
        userCashText.text = (user.GetComponent<UserInfo>().cash - money).ToString();
        user.GetComponent<UserInfo>().cash = int.Parse(userCashText.text);
        userAccountText.text = (user.GetComponent<UserInfo>().account + money).ToString();
        user.GetComponent<UserInfo>().account = int.Parse(userAccountText.text);
    }

    public void Withdraw(int money)
    {
        userAccountText.text = (user.GetComponent<UserInfo>().account - money).ToString();
        user.GetComponent<UserInfo>().account = int.Parse(userAccountText.text);
        userCashText.text = (user.GetComponent<UserInfo>().cash + money).ToString();
        user.GetComponent<UserInfo>().cash = int.Parse(userCashText.text);
    }
}
