using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel : MonoBehaviour
{
    public Button quitBtn;

    public Text noticText;

    private void Awake()
    {
        noticText.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        quitBtn.onClick.AddListener(() =>
        {
            noticText.gameObject.SetActive(true);
            //Application.Quit();
        });
    }
}
