using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CurrencyUnitController : MonoBehaviour
{
    private TMP_Text _number;
    private void Awake()
    {
        _number = gameObject.GetComponent<TMP_Text>();
    }

    private void Start()
    {
        bool b = int.TryParse(_number.text, out int result);
        Debug.Log(_number.text);
        Debug.Log(b + ""+ result);
        _number.text = string.Format("{0:#,###}", int.Parse(_number.text));
    }

    private void Update()
    {
        
    }
}
