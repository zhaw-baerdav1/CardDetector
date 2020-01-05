using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectIcon : MonoBehaviour
{
    public void Initialize(Transform panelTransform)
    {
        transform.SetParent(panelTransform);
        transform.localScale = Vector3.one;
        transform.localRotation = Quaternion.identity;
        transform.localPosition = Vector3.zero;
    }
}
