using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingWall : MonoBehaviour
{
    PlayerController Player;
    Rigidbody rb;
    bool stopVelocity;
    public GameObject plane;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.finish)
        {
            GetComponent<MeshRenderer>().enabled = true;
            if (!stopVelocity)
            {
                rb.velocity = new Vector3(0, 1, 0);
            }
           
        }   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PWSC")
        {
            other.gameObject.SetActive(false);
            stopVelocity = true;
            rb.isKinematic = true;
            plane.transform.parent = null;
            plane.GetComponent<MeshRenderer>().enabled = true;
            plane.GetComponent<MeshCollider>().enabled = true;
        }
    }
}
