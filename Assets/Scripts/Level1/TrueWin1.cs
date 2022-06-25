using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueWin1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            //TODO 游戏Trick结局
            Debug.Log("TrueWin1");
        }
    }
}
