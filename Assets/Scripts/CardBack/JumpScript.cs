using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class JumpScript : MonoBehaviour, IVirtualButtonEventHandler
{
	
	private GameObject customJumpButtonObject;
	
    [SerializeField]
	public Animator animator;
	
    void Start()
    {
    	customJumpButtonObject = GameObject.Find("CustomJumpButton");
    	customJumpButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    	
    }
    
    public void OnButtonReleased (VirtualButtonBehaviour vb){
    	animator.Play("jump-up");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

    }
}
