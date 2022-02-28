using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeBtn_click : MonoBehaviour
{
    public GameObject closeBtn;
    public GameObject popupPane;

    // Update is called once per frame    
    void Update() {  
        if (Input.GetMouseButtonDown(0)) {  
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {  

                if (hit.transform.name == closeBtn.name) {  
                    Debug.Log("Close button pressed");
                    popupPane.SetActive(false); 
                }  
            }  
        }  
    }  
}
