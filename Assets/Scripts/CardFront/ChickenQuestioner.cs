using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenQuestioner : MonoBehaviour
{
    private static System.Text.RegularExpressions.Regex _regex = new System.Text.RegularExpressions.Regex("\\{0\\}");
    private static string _multipleTextTemplate = "Lasse {0} Hühner erscheinen!";
    private static string _singleTextTemplate = "Lasse {0} Huhn erscheinen!";

    [SerializeField]
    private Text question;

    private int _generatedNumber = 0;

    private void Awake()
    {
        ChickenDetectedObjectList.OnDetectObjectListChanged += DetectedObjectList_OnDetectObjectListChanged;

        GenerateQuestion();
    }

    private void DetectedObjectList_OnDetectObjectListChanged(int count)
    {
        if ( count == _generatedNumber)
        {
            CorrectAnswerList.AddCorrectAnswer();
            GenerateQuestion();
        }
    }

    private void GenerateQuestion()
    {
        int newlyGeneratedNumber = CreateRandomNumber();
        while (_generatedNumber == newlyGeneratedNumber)
        {
            newlyGeneratedNumber = CreateRandomNumber();
        }

        _generatedNumber = newlyGeneratedNumber;
        UpdateText(_generatedNumber);
    }

    private void UpdateText(int number)
    {
        string output = _regex.Replace(_multipleTextTemplate, number.ToString());
        if (number == 1)
        {
            output = _regex.Replace(_singleTextTemplate, number.ToString());
        }

        question.text = output;
    }

    private int CreateRandomNumber()
    {
        return UnityEngine.Random.Range(1, 9);
    }

}
