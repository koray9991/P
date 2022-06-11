using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectors : MonoBehaviour
{
    public GameObject Character;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(Character.transform.position.x, Character.transform.position.y, Character.transform.position.z);
    }
}
