using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death1 : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            //TODO 游戏失败
            Debug.Log("Death1");
        }
    }
}
