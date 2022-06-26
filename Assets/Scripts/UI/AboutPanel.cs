using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutPanel : MonoBehaviour
{
    public Button backBtn;

    public GameObject startPanel;
    // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(() =>
        {
            this.gameObject.SetActive(false);
            startPanel.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
