using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Level3控制玩家移动的脚本
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("移动速度")]
    [SerializeField] private float moveSpeed = 10;
    private Rigidbody2D rb;

    private Vector2 inputDir;
    private Vector2 nowPos;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update 将输入转换为移动输入
    void Update()
    {
        nowPos.x = this.transform.position.x;
        nowPos.y = this.transform.position.y;
        inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        
    }

    // 通过MovePosition()移动
    private void FixedUpdate()
    {
        rb.MovePosition(nowPos += inputDir*(moveSpeed*Time.fixedDeltaTime));
    }
}
