using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour
{
    public Rigidbody rb;
    public float thrustMultiplier;
    private bool applyThrust = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thrustMultiplier = 0.03f;
    }

    void CheckKeys()
    {
        if(Input.GetKey(KeyCode.Space))       
        {
            print("space pressed");
            applyThrust = true;
        }
        else
        {
            applyThrust = false;
        }
    }
    void ApplyRocketThrust()
    {
        if (applyThrust)
        {
            print("thrust applied");

            Vector3 force = transform.up * thrustMultiplier;
            GetComponent<Rigidbody>().AddForce(force * 1000);
        }
    }

    //check keys + apply thrust in loop
    void FixedUpdate()
    {
        CheckKeys();
        ApplyRocketThrust();
    }
}