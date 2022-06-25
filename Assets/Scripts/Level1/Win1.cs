using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win1 : MonoBehaviour
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
        
        if (other.tag == "Finish")
        {
            //TODO 游戏胜利 +1分 切换场景
            Debug.Log("Win1");
            SceneManager.Instance.NewScene();
        }
    }
}
