using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerList : MonoBehaviour
{
    public static event Action<int> OnCorrectAnswerListChanged = delegate { };
    private static int count = 0;

    public static void AddCorrectAnswer()
    {
        count++;
        OnCorrectAnswerListChanged(count);
    }
    
}
