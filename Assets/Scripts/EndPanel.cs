using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel : MonoBehaviour
{
    public Button quitBtn;
    // Start is called before the first frame update
    void Start()
    {
        quitBtn.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
