using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public float rcsThrust = 100f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Rotate();
    }
  
    private void Rotate()
    {

        rb.freezeRotation = true; //om zelf rotation te kiezen

        float CurrentRotation = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.left * CurrentRotation);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //negatieve vector om van richting te veranderen
            transform.Rotate(-Vector3.left * CurrentRotation);
        }

        //rb.freezeRotation = false;

    }


}