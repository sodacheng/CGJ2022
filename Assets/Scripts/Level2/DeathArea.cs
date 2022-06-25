using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathArea : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //减血，跳到下一关
            Debug.Log("NextLevel,血量减一");
        }
    }

    
}
