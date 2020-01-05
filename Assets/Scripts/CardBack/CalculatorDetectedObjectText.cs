using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorDetectedObjectText : MonoBehaviour
{
    private void Awake()
    {
        CalculatorQuestioner.OnResultChanged += CalculatorQuestioner_OnResultChanged;
    }

    private void CalculatorQuestioner_OnResultChanged(int count)
    {
        GetComponent<Text>().text = count.ToString();
    }
}
