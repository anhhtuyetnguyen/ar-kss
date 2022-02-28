using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;
using Vuforia;

public class OpenURL : MonoBehaviour
{
    public GameObject OpenURLButton;
    public string URL;
    // Use this for initialization

 
    // Update is called once per frame    
    void Update() {  
    if (Input.GetMouseButtonDown(0)) {  
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
       RaycastHit hit;  
       if (Physics.Raycast(ray, out hit)) {  

           Debug.Log(hit.transform.name);
           if (hit.transform.name == OpenURLButton.name) {  
               Debug.Log("Button pressed");
               Application.OpenURL(URL);

                }  
            }  
        }  
    }  
}