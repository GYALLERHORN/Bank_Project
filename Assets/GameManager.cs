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
    public TMP_Text userCash;
    public TMP_Text userAccount;

    public bool isDepositRunning;

    private void Awake()
    {
        instance = this;
        userName.text = user.GetComponent<UserInfo>().userName;
        userCash.text = user.GetComponent<UserInfo>().cash.ToString();
        userAccount.text = user.GetComponent<UserInfo>().account.ToString();
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
        userCash.text = (int.Parse(userCash.text.Replace(",", "")) - money).ToString();
        userAccount.text = (int.Parse(userAccount.text.Replace(",", "")) + money).ToString();
    }

    public void Withdraw(int money)
    {
        userAccount.text = (int.Parse(userAccount.text.Replace(",", "")) - money).ToString();
        userCash.text = (int.Parse(userCash.text.Replace(",", "")) + money).ToString();
    }
}
