using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PickupScript : MonoBehaviour, IVirtualButtonEventHandler
{
	
	private GameObject customPickupButtonObject;

    [SerializeField]
    public Animator animator;
	
    void Start()
    {
    	customPickupButtonObject = GameObject.Find("CustomPickupButton");
    	customPickupButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    	
    }
    
    public void OnButtonPressed (VirtualButtonBehaviour vb){
    	
    }
    
    public void OnButtonReleased (VirtualButtonBehaviour vb){
    	animator.Play("pickup");
    }
}
