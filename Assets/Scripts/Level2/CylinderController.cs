using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    //旋转速度
    public float rotationAngle;
    //玩家控制的加速度变化速度
    public float angleAcculation;
    //反向调整的手感比例
    public float rate;
    // Start is called before the first frame update
    //控制玩家左右力的触发
    private bool isRight = false;

    private bool isLeft = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isRight = true;
        }
    }

    private void FixedUpdate()
    {
        LimitValue(rotationAngle,-1f,1f);
        Quaternion q = Quaternion.AngleAxis(rotationAngle,Vector3.forward);
        transform.rotation *= q;
        if (isLeft)
        {
            rotationAngle += angleAcculation * Time.fixedDeltaTime ;
            isLeft = false;

        }
        else if (isRight)
        {
            rotationAngle -= angleAcculation * Time.fixedDeltaTime ;
            isRight = false;
        }
    }

    public void LimitValue(float value,float min,float max)
    {
        if (value < min)
            value = min;
        else if (value > max)
        {
            value = max;
        }
    }


}
