using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenePanel : BasePanel
{
    public Text scoreText;
    public Text lifeText;

    public override void Init()
    {

    }

    public void UpdateScore(int num)
    {
        scoreText.text = "分数:" + num;
    }

    public void UpdateLife(int num)
    {
        lifeText.text = "生命:" + num + "/2";
    }
}
