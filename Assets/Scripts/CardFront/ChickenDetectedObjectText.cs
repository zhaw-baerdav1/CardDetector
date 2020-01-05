using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenDetectedObjectText : MonoBehaviour
{
    private void Awake()
    {
        ChickenDetectedObjectList.OnDetectObjectListChanged += DetectedObjectList_OnDetectObjectListChanged;
    }

    private void DetectedObjectList_OnDetectObjectListChanged(int count)
    {
        GetComponent<Text>().text = count.ToString();
    }
}
