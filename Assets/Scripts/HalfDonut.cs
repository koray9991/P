using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    [SerializeField] private bool ToRight;
    [SerializeField] private bool ToLeft;
    public float timer;
    public Rigidbody rb;
   public float maxtime;
  //  public bool ApplyForce;
  //  public float ForceTimer;
    void Start()
    {
        maxtime = Random.Range(3,7);
    }

    private void Update()
    {
        timer += Time.deltaTime;
    }
    void FixedUpdate()
    {
        if (ToRight)
        {
            if (timer < maxtime)
            {
                rb.velocity = new Vector3(-1, 0, 0);
            }
            else
            {
                rb.velocity = new Vector3(3, 0, 0);
                //    ForceTimer += Time.deltaTime;
                //   gameObject.tag = "ForceRight";
                //  if (ForceTimer > 0.3f)
                //  {
                //  gameObject.tag = "HalfDonut";
                //  }

                if (timer > maxtime+1)
                {
                    maxtime = Random.Range(2, 4);
                    timer = 0;
                    // ForceTimer = 0;
                }
            }
        }
        if (ToLeft)
        {
            if (timer < maxtime)
            {
                rb.velocity = new Vector3(1, 0, 0);
            }
            else
            {
                rb.velocity = new Vector3(-3, 0, 0);
                //  ForceTimer += Time.deltaTime;
                // gameObject.tag = "ForceLeft";
                //  if (ForceTimer > 0.3f)
                // {
                //  gameObject.tag = "HalfDonut";
                // }

                if (timer > maxtime + 1)
                {
                    maxtime = Random.Range(2, 4);
                    timer = 0;
                    //    ForceTimer = 0;
                }
            }
        }
    }
}
