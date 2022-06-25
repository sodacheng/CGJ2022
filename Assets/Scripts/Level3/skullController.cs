using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class skullController : MonoBehaviour
{
    public Transform target; // 玩家

    public Vector2 moveDir;

    public float moveSpeed;
    
    private void Awake()
    {
        target = GameObject.Find("Player").transform;
    }

    void Start()
    {
        // 先计算出生点与玩家当前的方向, 一直朝该方向直线移动.
        Vector3 tempDir = target.position - this.transform.position;
        tempDir = tempDir.normalized;
        moveDir.x = tempDir.x;
        moveDir.y = tempDir.y;
        Destroy(this.gameObject,3f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(moveDir*(moveSpeed*Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // 碰到玩家
        if (col.tag == "Player")
        {
            Debug.Log("Death");
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            //TODO 玩家死亡
        }
    }
}
