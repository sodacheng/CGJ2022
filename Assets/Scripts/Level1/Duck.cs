using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Duck : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 30f;
    private bool isJump = false;
    public bool isFly = false;

    private float timeC;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }


    private void Start()
    {
        print(Time.time);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
            //Debug.Log("Jump");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            timeC += Time.deltaTime;
            
        }
        else
        {
            timeC = 0;
        }

        if (timeC >= 2f)
        {
            isFly = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJump)
        {
            rb.AddForce(Vector3.up * jumpForce);
            isJump = false;
        }
        // else
        // {
        //     rb.AddForce(Vector3.down * 10);
        // }


        if (isFly)
        {
            rb.AddForce(Vector3.up * 1000f);
        }
    }
}
