using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RunScript : MonoBehaviour, IVirtualButtonEventHandler
{
	private GameObject customRunButtonObject;

    [SerializeField]
    public Animator animator;
	
    // Start is called before the first frame update
    void Start()
    {
    	customRunButtonObject = GameObject.Find("CustomRunButton");
    	customRunButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    
    public void OnButtonPressed (VirtualButtonBehaviour vb){
    	
    }
    
    public void OnButtonReleased (VirtualButtonBehaviour vb){
    	animator.Play("run");
    }
}
