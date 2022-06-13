using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;
public class Paintable : MonoBehaviour
{
   // public GameObject Brush;
   // public float brushSize= 0.005f;
   
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    

     /*   if (Input.GetMouseButton(0))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray ,out hit))
            {
                if (hit.transform.tag == "Paintable")
                {
                    var go = Instantiate(Brush, hit.point-Vector3.forward*0.01f, Quaternion.Euler(-90,0,0));
                    go.transform.localScale = Vector3.one * brushSize;
                }
                    
                
                    
                
                  
                
               
            }
        }*/
    }
}
