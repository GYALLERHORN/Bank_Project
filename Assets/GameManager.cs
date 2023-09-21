using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject user;

    public TMP_Text userName;
    public TMP_Text userCash;
    public TMP_Text userAccount;

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


    public void Deposit()
    {

    }

    public void Withdraw()
    {

    }
}
