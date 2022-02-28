using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;
using Vuforia;

public class popupBtn_click : MonoBehaviour
{
    public GameObject popupButton;
    public GameObject popupPane;
 
    // Use this for initialization
    void Start()
    {
        popupPane.SetActive(false);
    }
 
    // Update is called once per frame    
    void Update() {  
        if (Input.GetMouseButtonDown(0)) {  
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {  

                Debug.Log(hit.transform.name);
                if (hit.transform.name == popupButton.name) {  
                    Debug.Log("Popup button pressed");
                    popupPane.SetActive(true); 
                }  
            }  
        }  
    }  

}
