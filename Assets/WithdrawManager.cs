using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithdrawManager : ExchangeManager
{
    public override void RequestExchange() // 출금은 상속으로 진행해 봤다. Account->Cash
    {
        int moneyOnWaiting = int.Parse(_field.text);
        bool isAvailable = CheckAmountOf(moneyOnWaiting);
        if (isAvailable)
        {
            GameManager.instance.Withdraw(moneyOnWaiting);
            _field.text = "0";
        }
        else
        {
            alertPanel.SetActive(true);
        }
    }

    protected override bool CheckAmountOf(int moneyOnWaiting)
    {
        if (moneyOnWaiting > GameManager.instance.user.GetComponent<UserInfo>().account)
        {
            return false;
        }
        return true;
    }
}
