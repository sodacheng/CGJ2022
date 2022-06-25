using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class TrueWin3 : MonoBehaviour
{

    public Transform block;
    public GameObject builder;
    public float moveSpeed;


        

    private void FixedUpdate()
    {
        block.transform.Translate(this.transform.right * (Time.fixedDeltaTime * moveSpeed));
    }
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            //TODO TrueWIn
            Debug.Log("TrueWin");
            Destroy(col.gameObject);
            Destroy(builder.gameObject);
        }
    }
}
