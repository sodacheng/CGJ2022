using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelPanel : MonoBehaviour
{
    public Button nextBtn;

    public string nextScene;
    void Start()
    {
        nextBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(nextScene);
        });
        
        this.gameObject.SetActive(false);
    }

}
