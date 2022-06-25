using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death1 : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            //游戏失败 重开
            Debug.Log("Death1");
            SceneManager.LoadScene("Level1");
        }
    }
}
