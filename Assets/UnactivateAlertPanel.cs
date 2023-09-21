using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnactivatePanel : MonoBehaviour
{
    [SerializeField] private GameObject alertBoard;
    [SerializeField] private TMP_Text alertDetail;

    private void Awake()
    {
        
    }
    private void Start()
    {
        alertDetail.text = $"Exchange is more then Cash";
        if (!GameManager.instance.isDepositRunning)
        {
            alertDetail.text = $"Exchange is more then Account"; 
        }
    }

    public void Unactivate()
    {
        gameObject.SetActive(false);
    }
}
