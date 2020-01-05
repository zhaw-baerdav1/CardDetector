using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CustomSwitchButton : MonoBehaviour
{

    [SerializeField]
    private GameObject cardFront;
    [SerializeField]
    private GameObject cardBack;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(SwitchLayout);
    }

    private void SwitchLayout()
    {
        cardFront.SetActive(!cardFront.activeSelf);
        cardBack.SetActive(!cardBack.activeSelf);

        FindObjectOfType<CustomSwitchButtonImage>().SwitchImage(cardFront.activeSelf);
    }
}
