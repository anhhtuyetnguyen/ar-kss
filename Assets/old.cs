using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;
using Vuforia;

public class vb_anim_old : MonoBehaviour
{
    public GameObject vbBtnObj;
    public Animator cubeAni;
 
    // Use this for initialization
    void Start()
    {
        // vbBtnObj = GameObject.Find("VirtualButton1");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
 
        cubeAni.GetComponent<Animator>();
    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("cube_animation");
        Debug.Log("Button pressed");
        Debug.Log(vb);
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Button released");
    }
}
