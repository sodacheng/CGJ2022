using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class RingBuilder : MonoBehaviour
{
    
    public GameObject ring;
    public Ring ringScript;
    public float timeCount;
    void Start()
    {
        //TODO 根据关卡数设置 火圈 的速度

        BuildRing();
    }

    private void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount >= 3)
        {
            BuildRing();
            timeCount = 0;
        }
    }

    public void BuildRing()
    {
        GameObject obj = GameObject.Instantiate(ring);
        obj.transform.position = this.transform.position;
    }
}
