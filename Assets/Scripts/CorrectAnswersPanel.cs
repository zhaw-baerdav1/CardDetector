using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswersPanel : MonoBehaviour
{

    [SerializeField]
    private CorrectIcon correctIconPrefab;

    [SerializeField]
    private Transform effect;

    private void Awake()
    {
        CorrectAnswerList.OnCorrectAnswerListChanged += CorrectAnswerList_OnCorrectAnswerListChanged;
    }

    private void CorrectAnswerList_OnCorrectAnswerListChanged(int count)
    {
        var effectTransform = Instantiate(effect, new Vector3(0, 0.1f, 0), Quaternion.identity);
        effectTransform.SetParent(transform);

        var icon = Instantiate(correctIconPrefab);
        icon.Initialize(transform);
    }
}
