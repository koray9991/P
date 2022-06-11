using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentCharacter : MonoBehaviour
{
    public Animator anim;
    float StartToRun;
    float TimerStartToRun;
    public Rigidbody rb;
    float xMovement;
    float zMovement;
    public GameObject leftForward,rightForward,MiddleForward;
    public bool HorizontalObstacleStop;
    public bool StaticObstacleStop;
    public bool DonutObstacleStop;
    void Start()
    {
        StartToRun = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        TimerStartToRun += Time.deltaTime;
        if (zMovement == 1)
        {
            anim.SetInteger("Movement", 1);
        }
        else
        {
            anim.SetInteger("Movement", 0);
        }

        if (TimerStartToRun > StartToRun && !HorizontalObstacleStop)
        {
            zMovement = 1;


        }
        else
        {
            zMovement = 0;
        }
        if (leftForward.GetComponent<LeftForward>().HorizontalObstacleDetect || rightForward.GetComponent<RightForward>().HorizontalObstacleDetect || MiddleForward.GetComponent<MiddleForward>().HorizontalObstacleDetect)
        {
            HorizontalObstacleStop = true;
            StartCoroutine(HorizontalStop());
        }
        if(leftForward.GetComponent<LeftForward>().StaticObstacleDetect && !rightForward.GetComponent<RightForward>().StaticObstacleDetect)
        {
            xMovement = 0.7f;
            if (!MiddleForward.GetComponent<MiddleForward>().StaticObstacleDetect)
            {
                xMovement = 0;
            }
            
        }
        if (!leftForward.GetComponent<LeftForward>().StaticObstacleDetect && rightForward.GetComponent<RightForward>().StaticObstacleDetect)
        {
            xMovement = -0.7f;
            if (!MiddleForward.GetComponent<MiddleForward>().StaticObstacleDetect)
            {
                xMovement = 0;
            }

        }
        if (leftForward.GetComponent<LeftForward>().StaticObstacleDetect && rightForward.GetComponent<RightForward>().StaticObstacleDetect)
        {
            if (transform.position.x < 0)
            {
                xMovement = 1f;
            }
            if (transform.position.x > 0)
            {
                xMovement = -1f;
            }

            StartCoroutine(StaticObstacleMovement());

        }
        if (leftForward.GetComponent<LeftForward>().DonutObstacleDetect && !rightForward.GetComponent<RightForward>().DonutObstacleDetect)
        {
            xMovement = 0.5f;
            if (!MiddleForward.GetComponent<MiddleForward>().DonutObstacleDetect)
            {
                xMovement = 0;
            }

        }
        if (!leftForward.GetComponent<LeftForward>().DonutObstacleDetect && rightForward.GetComponent<RightForward>().DonutObstacleDetect)
        {
            xMovement = -0.5f;
            if (!MiddleForward.GetComponent<MiddleForward>().DonutObstacleDetect)
            {
                xMovement = 0;
            }

        }
    }

    private IEnumerator StaticObstacleMovement()
    {
      
        yield return new WaitForSeconds(0.7f);
        xMovement = 0;
    }
    private IEnumerator HorizontalStop()
    {
        zMovement = 0;
        yield return new WaitForSeconds(0.4f);
        HorizontalObstacleStop = false;
        zMovement = 1;
    }
    private void FixedUpdate()
    {
      
        rb.velocity = new Vector3(xMovement, rb.velocity.y, zMovement);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn" || other.tag == "HorizontalObstacle" || other.tag == "StaticObstacle" || other.tag == "HalfDonut")
        {
            transform.position = new Vector3(Random.Range(-0.4f, 0.4f), 0, Random.Range(-0.3f, 0f));
            rb.velocity = Vector3.zero;
            TimerStartToRun = 0;
            anim.SetInteger("Movement", 0);
            StartToRun = Random.Range(0, 3);
            HorizontalObstacleStop = false;

            leftForward.GetComponent<LeftForward>().HorizontalObstacleDetect = false;
            rightForward.GetComponent<RightForward>().HorizontalObstacleDetect = false;
            MiddleForward.GetComponent<MiddleForward>().HorizontalObstacleDetect = false;

            leftForward.GetComponent<LeftForward>().StaticObstacleDetect = false;
            rightForward.GetComponent<RightForward>().StaticObstacleDetect = false;
            MiddleForward.GetComponent<MiddleForward>().StaticObstacleDetect = false;

            leftForward.GetComponent<LeftForward>().DonutObstacleDetect = false;
            rightForward.GetComponent<RightForward>().DonutObstacleDetect = false;
            MiddleForward.GetComponent<MiddleForward>().DonutObstacleDetect = false;
            xMovement = 0;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RotatingPlatform")
        {

            xMovement = collision.gameObject.GetComponent<RotatingPlatform>().z/3;
        }
        if (collision.gameObject.tag == "HalfDonut")
        {
            transform.position = new Vector3(Random.Range(-0.4f, 0.4f), 0, Random.Range(-0.3f, 0f));
            rb.velocity = Vector3.zero;
            TimerStartToRun = 0;
            anim.SetInteger("Movement", 0);
            StartToRun = Random.Range(0, 3);
            HorizontalObstacleStop = false;

            leftForward.GetComponent<LeftForward>().HorizontalObstacleDetect = false;
            rightForward.GetComponent<RightForward>().HorizontalObstacleDetect = false;
            MiddleForward.GetComponent<MiddleForward>().HorizontalObstacleDetect = false;

            leftForward.GetComponent<LeftForward>().StaticObstacleDetect = false;
            rightForward.GetComponent<RightForward>().StaticObstacleDetect = false;
            MiddleForward.GetComponent<MiddleForward>().StaticObstacleDetect = false;

            leftForward.GetComponent<LeftForward>().DonutObstacleDetect = false;
            rightForward.GetComponent<RightForward>().DonutObstacleDetect = false;
            MiddleForward.GetComponent<MiddleForward>().DonutObstacleDetect = false;

            xMovement = 0;

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "RotatingPlatform")
        {
            xMovement = 0;
        }
    }
}
