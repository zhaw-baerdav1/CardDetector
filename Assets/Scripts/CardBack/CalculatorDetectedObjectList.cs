using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorDetectedObjectList : MonoBehaviour
{
    public static event Action<HashSet<String>> OnDetectObjectListChanged = delegate { };
    private static HashSet<String> detectedObjectList = new HashSet<String>();


    public static void AddDetectedObject(String name)
    {
        detectedObjectList.Add(name);
        OnDetectObjectListChanged(detectedObjectList);
    }

    public static void RemoveDetectedObject(String name)
    {
        detectedObjectList.Remove(name);
        OnDetectObjectListChanged(detectedObjectList);
    }
}
