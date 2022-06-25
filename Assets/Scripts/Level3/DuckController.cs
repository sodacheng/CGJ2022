using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuckController : MonoBehaviour
{
    public NextLevelPanel nextLevelPanel;
    
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
        maxRotateSpeed = 6;
        forwardSpeed = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        CheckUpDown();
    }

    private void FixedUpdate()
    {
        
        
        if (allowMove)
        {
            transform.position += Vector3.forward * forwardSpeed * Time.fixedDeltaTime;
        }

        if (transform.position.z > 4.3f)
        {
            //Restart
            SceneManager.LoadScene("Level3");
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
                PlayerStop();
            }
            else 
            {
                transform.SetParent(cylinder.transform);
                if (rb != null)
                {
                    rb = null;
                }
                rb = null;
                //禁止控制,进入真结局
                PlayerStop();
                Debug.Log("进入Level2真结局");
                nextLevelPanel.gameObject.SetActive(true);
                
            }
        }
        else
        {
            if (rb != null)
            {
                rb = null;
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Finish"))
        {
            transform.parent = null;
            if (rb != null)
            {
                rb.freezeRotation = true;
            }

            PlayerStop();
        }
    }

    void PlayerStop()
    {
        allowMove = false;
        CylinderController.allowControl = false;
        //不让圆柱动了
        //cylinder.GetComponent<CylinderController>().rotationAngle = 0f;
    }
}
