using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using System;
using UnityEngine.UI;
  
public class Movement : MonoBehaviour  
{  
    Vector3 Vec;  
    // Start is called before the first frame update  
    void Start()  
    {  
          
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
  
        // Vec = transform.localPosition;  
        // Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;  
        // Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;  
        // Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;  
        // transform.localPosition = Vec;  

        if (Input.GetKey(KeyCode.UpArrow))  
        {  
            this.transform.Translate(Vector3.up * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            this.transform.Translate(Vector3.down * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -1);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, 1);  
        }  

        if (Input.GetKey(KeyCode.A))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime );  
        }  

        if (Input.GetKey(KeyCode.D))  
        {  
            this.transform.Translate(Vector3.back * Time.deltaTime );  
        }  

        if (Input.GetKey(KeyCode.W))  
        {  
            this.transform.Translate(Vector3.left * Time.deltaTime );  
        }  

         if (Input.GetKey(KeyCode.S))  
        {  
            this.transform.Translate(Vector3.right * Time.deltaTime );  
        }  
    }  
}  