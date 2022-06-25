using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;


/// <summary>
/// 关卡控制器
/// </summary>
public class SceneManager : MonoBehaviour
{
    private static SceneManager instance;
    public static SceneManager Instance => instance;

    public int score = 0; // 得分(已经通过的关卡数)
    public int nowScene = 1; // 当前载入的关卡 
    public int life = 2; // 生命

    public List<int> sceneList = new List<int>(){ 1, 2, 3 }; // TODO 关卡列表 做好了关卡在这里加就可以.

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


    /// <summary>
    /// 通关时调用该方法,得分加一,并加载新关卡
    /// Win(假胜利)调用此方法
    /// </summary>
    public void NewScene()
    {
        score++;
        
        //更新UI分数显示
        UIManager.Instance.GetPanel<ScenePanel>().UpdateScore(score); // 失败时更新生命同理
        
        
        int count = sceneList.Count;
        int temp = Random.Range(1, count + 1);
        print(temp);
        nowScene = sceneList[temp];
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level" + nowScene); // 切换关卡  可以封装用Invoke()延时触发, 先显示UI 显示提示 并在几秒后小时,衔接游戏加载
        
    }

    /// <summary>
    /// 调用该方法时,删除当前关卡,如果还有关卡,则进入下一关,如果没有关卡了, 则游戏结束.
    ///  TrueEnd(真胜利)调用此方法
    /// </summary>
    public void DelScene()
    {
        if (sceneList.Contains(nowScene))
        {
            Debug.Log("DelScene Success!");
            sceneList.Remove(nowScene);
        }

        if (sceneList.Count > 0)
        {
            NewScene();
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndScene"); // 显示结束关卡, TODO 还没做.
        }
    }

    // 失败时调用此方法
    public void FailScene()
    {
        --life;
        UIManager.Instance.GetPanel<ScenePanel>().UpdateLife(life);
        if (life > 0)
        {
            NewScene();
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndScene"); // TODO 失败重试UI 没做
        }
    }
}
