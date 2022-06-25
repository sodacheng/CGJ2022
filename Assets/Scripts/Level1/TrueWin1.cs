using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueWin1 : MonoBehaviour
{
    public GameObject NextLevelPanel;
    private void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            //TODO 游戏Trick结局
            Debug.Log("TrueWin1");
            print(Time.time);
            Destroy(other.gameObject);
            NextLevelPanel.SetActive(true);
            print("弹出菜单");
        }
    }
}
