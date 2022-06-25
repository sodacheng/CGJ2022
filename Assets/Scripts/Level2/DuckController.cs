using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour
{
    //初始化获取的组件
   private Rigidbody rb;

    public Transform cylinder;
    public float maxRotateSpeed;
    

    private bool allowMove = true;
    //控制duck移动的系数
    public float forwardSpeed = 1;



    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
        CheckUpDown();
        if (allowMove)
        {
            transform.position += Vector3.forward * forwardSpeed * Time.fixedDeltaTime;
        }

        if (transform.position.z > 4.3f)
        {
            //进入下一关卡
            Debug.Log("NextLevel");
        }
        
    }

    void CheckUpDown()
    {
        float a = Vector3.Dot(cylinder.transform.up, Vector3.up);  
        if (a < 0.5f)
        {
            if (cylinder.GetComponent<CylinderController>().rotationAngle < maxRotateSpeed)
            {
                transform.parent = null;
                if (rb == null)
                {
                    rb = gameObject.AddComponent<Rigidbody>();
                }
                allowMove = false;
            }
            else 
            {
                //进入真结局
                Debug.Log("进入Level2真结局");
            }
        }
        else
        {
            if (rb != null)
            {
                rb = null;
            }
            rb = null;
            
        }
    }
}
