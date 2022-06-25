using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Duck : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 30f;
    private bool isJump = false;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isJump = true;
            Debug.Log("Jump");
        }
        else
        {
            isJump = false;
        }
    }

    private void FixedUpdate()
    {
        if (isJump)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
