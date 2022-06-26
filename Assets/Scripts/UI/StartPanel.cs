using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : MonoBehaviour
{
    public GameObject level;

    public Button aboutBtn;

    public GameObject aboutPanel;
    // Start is called before the first frame update
    

    void Start()
    {
        aboutPanel.SetActive(false);
        aboutBtn.onClick.AddListener(() =>
        {
            this.gameObject.SetActive(false);
            aboutPanel.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        level.SetActive(true);
    }
}
