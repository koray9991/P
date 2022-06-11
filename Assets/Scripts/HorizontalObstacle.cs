using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalObstacle : MonoBehaviour
{
    
   public  bool moveRight;
    [SerializeField] private float MovementSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveRight)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(MovementSpeed, 0, 0);
        }
        else
        {
           GetComponent<Rigidbody>().velocity = new Vector3(-MovementSpeed, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "MoveLeft")
        {
            
            moveRight = false;
            
        }
        if (other.tag == "MoveRight")
        {
            
            moveRight = true;

        }
    }
}
