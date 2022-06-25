using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
public class TrueWin3 : MonoBehaviour
{

    public Transform block;
    public GameObject builder;
    public float moveSpeed;

    public GameObject map; // 真结局会删除地图
    public float timeCount; // 计时用变量


    private void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount > 30f)
        {
            // TODO 当玩家没有离开出口,且坚持30秒时, 清空游戏地图,只留下玩家,触发真结局
            Destroy(map);
            // Invoke(trueEnd,2);
        }
    }

    private void FixedUpdate()
    {
        block.transform.Translate(this.transform.right * (Time.fixedDeltaTime * moveSpeed));
    }
    
    
    /// <summary>
    /// 玩家从出口离开, 普通胜利, 加一分.
    /// </summary>
    /// <param name="col"></param>
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("Win");
            Destroy(col.gameObject);
            Destroy(builder.gameObject);
            
            // 下一关
        }
    }
}
