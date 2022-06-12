using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentCharacter : MonoBehaviour
{
    public Animator anim;
   public float StartToRun;
    float TimerStartToRun;
    public Rigidbody rb;
    float xMovement;
    float zMovement;
    public GameObject leftForward,rightForward,MiddleForward,Detectors;
    public bool HorizontalObstacleStop;
    public bool StaticObstacleStop;
    public bool DonutObstacleStop;
    public bool RotatorObstacleStop;
   public bool hitRotatingStick;
    public bool Finish;
    void Start()
    {
        StartToRun = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        TimerStartToRun += Time.deltaTime;
        if (zMovement == 1 && !Finish)
        {
            anim.SetInteger("Movement", 1);
        }
       if( zMovement==0 && !Finish)
        {
            anim.SetInteger("Movement", 0);
        }
        
        if (TimerStartToRun > StartToRun && !HorizontalObstacleStop && !DonutObstacleStop && !hitRotatingStick && !Finish)
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
            StartCoroutine(DonutStopZPlus());
            DonutObstacleStop = true;
            
            if (!MiddleForward.GetComponent<MiddleForward>().DonutObstacleDetect)
            {
                xMovement = 0;
            }

        }
        if (!leftForward.GetComponent<LeftForward>().DonutObstacleDetect && rightForward.GetComponent<RightForward>().DonutObstacleDetect)
        {
            StartCoroutine(DonutStopZMinus());
            DonutObstacleStop = true;
           
            if (!MiddleForward.GetComponent<MiddleForward>().DonutObstacleDetect)
            {
                xMovement = 0;
            }

        }









        if (leftForward.GetComponent<LeftForward>().RotatorObstacleDetect && !rightForward.GetComponent<RightForward>().RotatorObstacleDetect)
        {
            xMovement = 0.7f;
            if (!MiddleForward.GetComponent<MiddleForward>().RotatorObstacleDetect)
            {
                xMovement = 0;
            }
            StartCoroutine(StaticObstacleMovement());
        }
        if (!leftForward.GetComponent<LeftForward>().RotatorObstacleDetect && rightForward.GetComponent<RightForward>().RotatorObstacleDetect)
        {
            xMovement = -0.7f;
            if (!MiddleForward.GetComponent<MiddleForward>().RotatorObstacleDetect)
            {
                xMovement = 0;
            }
            StartCoroutine(StaticObstacleMovement());

        }
        if (leftForward.GetComponent<LeftForward>().RotatorObstacleDetect && rightForward.GetComponent<RightForward>().RotatorObstacleDetect)
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

    }

    private IEnumerator StaticObstacleMovement()
    {
      
        yield return new WaitForSeconds(0.7f);
        xMovement = 0;
    }
   
    private IEnumerator DonutStopZPlus()
    {
        zMovement = 0;
        yield return new WaitForSeconds(0.3f);
        DonutObstacleStop = false;
        xMovement = 0.7f;
        zMovement = 1;
        StartCoroutine(DonutXZero());
    }
    private IEnumerator DonutStopZMinus()
    {
        zMovement = 0;
        yield return new WaitForSeconds(0.3f);
        DonutObstacleStop = false;
        xMovement = -0.7f;
        zMovement = 1;
        StartCoroutine(DonutXZero());
    }
    private IEnumerator DonutXZero()
    {

        yield return new WaitForSeconds(0.4f);
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
        if (!hitRotatingStick) 
            {
            rb.velocity = new Vector3(xMovement, rb.velocity.y, zMovement);
        } 
       
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

            leftForward.GetComponent<LeftForward>().RotatorObstacleDetect = false;
            rightForward.GetComponent<RightForward>().RotatorObstacleDetect = false;
            MiddleForward.GetComponent<MiddleForward>().RotatorObstacleDetect = false;

            xMovement = 0;

        }
    }
    private IEnumerator rotatingStickZMovement()
    {
        yield return new WaitForSeconds(0.7f);
        hitRotatingStick = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "FinishBot")
        {
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z - 0.01f);
            Finish = true;
            Detectors.SetActive(false);
            rb.isKinematic = true;
            GetComponent<CapsuleCollider>().enabled = false;
            anim.SetInteger("Movement", 2);

        }
        if (collision.gameObject.tag == "RotatingStick")
        {
            hitRotatingStick = true;
            StartCoroutine(rotatingStickZMovement());
            rb.AddForce(Random.Range(-50, 50), 120, -120);
        }
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

            leftForward.GetComponent<LeftForward>().RotatorObstacleDetect = false;
            rightForward.GetComponent<RightForward>().RotatorObstacleDetect = false;
            MiddleForward.GetComponent<MiddleForward>().RotatorObstacleDetect = false;

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
