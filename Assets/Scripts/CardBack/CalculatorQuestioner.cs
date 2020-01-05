using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorQuestioner : MonoBehaviour
{
    private static System.Text.RegularExpressions.Regex _regex = new System.Text.RegularExpressions.Regex("\\{0\\}");
    private static string _textTemplate = "Lasse die Summe von {0} erscheinen!";


    [SerializeField]
    private Text question;

    private int _generatedResult = -1;

    private Dictionary<String, int> calculatorMap = new Dictionary<String, int>();

    public static event Action<int> OnResultChanged = delegate { };

    private void Awake()
    {
        CalculatorDetectedObjectList.OnDetectObjectListChanged += DetectedObjectList_OnDetectObjectListChanged;

        calculatorMap.Add("pig_female", 1);
        calculatorMap.Add("monkey_female", 2);
        calculatorMap.Add("goose_female", 3);
        calculatorMap.Add("goat_female", 4);
        calculatorMap.Add("elephant_female", 5);
        calculatorMap.Add("donkey_female", 6);
        calculatorMap.Add("dog_female", 7);
        calculatorMap.Add("bear_female", 8);

        GenerateQuestion();
    }

    private void DetectedObjectList_OnDetectObjectListChanged(HashSet<String> detectedObjectList)
    {
        int result = CalculateResult(detectedObjectList);
        OnResultChanged(result);

        if (result == _generatedResult)
        {
            CorrectAnswerList.AddCorrectAnswer();
            GenerateQuestion();
        }
    }

    private int CalculateResult(HashSet<String> detectedObjectList)
    {
        int result = 0;
        foreach (String detectedObjectName in detectedObjectList)
        {
            result += calculatorMap[detectedObjectName];
        }

        return result;
    }

    private void GenerateQuestion()
    {
        int cardCount = UnityEngine.Random.Range(1, 5);

        List<String> cardList = new List<String>(calculatorMap.Keys);
        HashSet<String> resultCardList = new HashSet<String>();
        for (int i = 0; i < cardCount; i++)
        {
            String cardName;
            do
            {
                int newlyGeneratedNumber = CreateRandomNumber();
                cardName = cardList[newlyGeneratedNumber-1];
            } while (resultCardList.Contains(cardName));

            resultCardList.Add(cardName);
        }

        _generatedResult = CalculateResult(resultCardList);
        UpdateText(_generatedResult);
    }

    private void UpdateText(int number)
    {
        string output = _regex.Replace(_textTemplate, number.ToString());
        question.text = output;
    }

    private int CreateRandomNumber()
    {
        return UnityEngine.Random.Range(1, 9);
    }

}
