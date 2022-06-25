using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 第二关的UI面板
/// 第二关的倒计时会从15倒计时到-15 当-15时,游戏会自动过关
/// </summary>
public class Level2Panel : MonoBehaviour
{
    public Text timeText;

    public void UpdateText(int num)
    {
        timeText.text = "倒计时" + num + "/15";
    }
}
