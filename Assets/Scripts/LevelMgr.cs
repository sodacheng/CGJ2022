using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LevelMgr
{
    private static LevelMgr instance = new LevelMgr();
    public static LevelMgr Instance => instance;


    private LevelMgr()
    {
        
    }

    // 记录当前的关卡
    public int nowLevel = 1;
}
