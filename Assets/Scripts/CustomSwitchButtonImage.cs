using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomSwitchButtonImage : MonoBehaviour
{

    [SerializeField]
    private Sprite onImage;
    [SerializeField]
    private Sprite offImage;

    public void SwitchImage(bool on)
    {
        Sprite buttonSprite = offImage;
        if (on)
        {
            buttonSprite = onImage; 
        }

        GetComponent<Image>().sprite = buttonSprite;
    }
}

        




