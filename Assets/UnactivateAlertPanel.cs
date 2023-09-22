using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnactivatePanel : MonoBehaviour
{
    [SerializeField] private GameObject alertBoard;
    [SerializeField] private TMP_Text alertDetail;

    private void OnEnable()
    {
        alertDetail.text = "Exchange is bigger than Cash";
        if (!GameManager.instance.isDepositRunning)
        {
            alertDetail.text = "Exchange is bigger than Account"; 
        }
    }

    public void Unactivate()
    {
        gameObject.SetActive(false);
    }
}
