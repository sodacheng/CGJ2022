using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueWin1 : MonoBehaviour
{

    
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            //TODO 游戏Trick结局
            Debug.Log("TrueWin1");
            print(Time.time);
            Destroy(other.gameObject);

            //SceneManager.Instance.DelScene();
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
        }
    }
}
