using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswersPanel : MonoBehaviour
{

    [SerializeField]
    private CorrectIcon correctIconPrefab;

    [SerializeField]
    private ParticleSystem particlePrefab;

    private void Awake()
    {
        CorrectAnswerList.OnCorrectAnswerListChanged += CorrectAnswerList_OnCorrectAnswerListChanged;
    }

    private void CorrectAnswerList_OnCorrectAnswerListChanged(int count)
    {
        particlePrefab.Play();

        var icon = Instantiate(correctIconPrefab);
        icon.Initialize(transform);
    }
}
