using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 场景的控制刺旋转的脚本
/// </summary>
public class Spike : MonoBehaviour
{
    [Header("刺的旋转速度")] public float rotateSpeed = 200f;

    void Update()
    {
        this.transform.Rotate(Vector3.up * (Time.deltaTime * rotateSpeed));
    }
}