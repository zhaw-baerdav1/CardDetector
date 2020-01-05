using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDetectedObjectList : MonoBehaviour
{
    public static event Action<int> OnDetectObjectListChanged = delegate { };
    private static HashSet<int> detectedObjectList = new HashSet<int>();


    public static void AddDetectedObject(int hashCode)
    {
        detectedObjectList.Add(hashCode);
        OnDetectObjectListChanged(detectedObjectList.Count);
    }

    public static void RemoveDetectedObject(int hashCode)
    {
        detectedObjectList.Remove(hashCode);
        OnDetectObjectListChanged(detectedObjectList.Count);
    }
}
