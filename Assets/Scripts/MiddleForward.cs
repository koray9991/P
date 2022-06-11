using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleForward : MonoBehaviour
{
    public bool HorizontalObstacleDetect;
    public bool StaticObstacleDetect;
    public bool DonutObstacleDetect;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HorizontalObstacle")
        {
            HorizontalObstacleDetect = true;
        }
        if (other.tag == "StaticObstacle")
        {
            StaticObstacleDetect = true;
        }
        if (other.tag == "DonutCollider")
        {
            DonutObstacleDetect = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "HorizontalObstacle")
        {
            HorizontalObstacleDetect = false;
        }
        if (other.tag == "StaticObstacle")
        {
            StaticObstacleDetect = false;
        }
        if (other.tag == "DonutCollider")
        {
            DonutObstacleDetect = false;
        }
    }
}
