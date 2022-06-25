using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueWin3 : MonoBehaviour
{

    public Transform block;
    public GameObject builder;
    public float moveSpeed;

    public GameObject map; // 真结局会删除地图
    //public float timeCount; // 计时用变量
    public float UITime; // 用于显示在UI上的时间

    public Level2Panel Level2Panel;
    public NextLevelPanel NextLevelPanel;

    private void Awake()
    {
        UITime = 15;
    }

    private void Update()
    {
        UITime -= Time.deltaTime;
        if (UITime <-15)
        {
            Destroy(map);
            Destroy(builder);
            NextLevelPanel.gameObject.SetActive(true);
            UITime = -15f;
        }
        Level2Panel.UpdateText((int)UITime);
    }

    private void FixedUpdate()
    {
        block.transform.Translate(this.transform.right * (Time.fixedDeltaTime * moveSpeed));
    }
    
    
    /// <summary>
    /// 玩家从出口离开, 会重新开始游戏
    /// </summary>
    /// <param name="col"></param>
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
