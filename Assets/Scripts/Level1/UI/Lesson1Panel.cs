using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 关卡1的得分UIPanel
/// </summary>
public class Lesson1Panel : MonoBehaviour
{
    public Text scoreText;

    public void UpdateScore(int num)
    {
        scoreText.text = "得分:" + num + "/20";
    }
}
