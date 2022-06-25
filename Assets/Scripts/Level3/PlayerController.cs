using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nowPos.x = this.transform.position.x;
        nowPos.y = this.transform.position.y;
        inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(nowPos += inputDir*(moveSpeed*Time.fixedDeltaTime));
    }
}
