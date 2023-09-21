using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithdrawManager : ExchangeManager
{
    public override void RequestExchange() // ����� ������� ������ �ô�. Account->Cash
    {
        int moneyOnWaiting = int.Parse(_field.text);
        bool isAvailable = CheckAmountOf(moneyOnWaiting);
        if (isAvailable)
        {
            GameManager.instance.Withdraw(moneyOnWaiting);
        }
        else
        {
            alertPanel.SetActive(true);
        }
    }

    protected override bool CheckAmountOf(int moneyOnWaiting)
    {
        if (moneyOnWaiting > int.Parse(GameManager.instance.userAccount.text))
        {
            return false;
        }
        return true;
    }
}
