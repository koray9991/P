using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float zhiz;
    float touchposx;
    [SerializeField] private float controlspeed;
    public Rigidbody rb;
    bool istouching;
    public bool finish;
    bool hitRotatingStick;
  //  public Quaternion currentAngle;
   // Quaternion targetAngle30 = Quaternion.Euler(0, 30, 0);
   // Quaternion targetAngleminus30 = Quaternion.Euler(0, -30, 0);
    public Animator anim;
    bool respawn;
    private void Start()
    {


    }
    private void Update()
    {
        getinput();
        // changeCurrentAngle();
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    private void FixedUpdate()
    {
       

        if (respawn)
        {
            transform.position = new Vector3(Random.Range(-0.4f,0.4f), 0, Random.Range(-0.3f, 0f));
            respawn = false;
            rb.velocity = Vector3.zero;
            touchposx = 0;
        }
        else
        {
          if(istouching && !finish)
            {
                if (Input.GetAxis("Mouse X") > 0)
                {
                    rb.velocity = new Vector3(controlspeed, rb.velocity.y, zhiz);
                }
                if (Input.GetAxis("Mouse X") < 0)
                {
                    rb.velocity = new Vector3(-controlspeed, rb.velocity.y, zhiz);
                }
                if (Input.GetAxis("Mouse X") == 0)
                {
                    rb.velocity = new Vector3(0, rb.velocity.y, zhiz);
                }
            }
          
        }
       
        
    }
    void getinput()
    {
        if (Input.GetMouseButton(0) && !finish && !hitRotatingStick)
        {
            istouching = true;
            zhiz = 1;
            anim.SetInteger("Movement", 1);
        }
        else
        {
            istouching = false;
            zhiz = 0;
            anim.SetInteger("Movement", 0);
            touchposx = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn" || other.tag == "HorizontalObstacle" || other.tag == "StaticObstacle" || other.tag == "HalfDonut")
        {
            respawn = true;
          
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
            finish = true;
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z - 0.01f);
            //  other.gameObject.SetActive(false);
            //  other.GetComponent<BoxCollider>().enabled = false;
        }
        if (collision.gameObject.tag == "RotatingStick")
        {
            hitRotatingStick = true;
            StartCoroutine(rotatingStickZMovement());
            rb.AddForce(Random.Range(-50,50), 120, -120);
        }
        if( collision.gameObject.tag == "HalfDonut")
        {
            respawn = true;
        }
        if (collision.gameObject.tag == "RotatingPlatform")
        {
            transform.parent = collision.gameObject.transform;
        }
     /*   if (collision.gameObject.tag == "ForceRight")
        {
            rb.AddForce(new Vector3(250, 0, 0));
        }
        if (collision.gameObject.tag == "ForceLeft")
        {
            rb.AddForce(new Vector3(-250, 0, 0));
        }*/
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "RotatingPlatform")
        {
            transform.parent =null;
        }
    }
    /*  void changeCurrentAngle()
      {
          if (currentAngle.eulerAngles.y >= targetAngle30.eulerAngles.y && touchposx>0)
          {
              currentAngle = targetAngle30;
          }
          if (currentAngle.eulerAngles.y <= targetAngle30.eulerAngles.y && touchposx < 0)
          {
              currentAngle = targetAngleminus30;
          }
      }
    */

}