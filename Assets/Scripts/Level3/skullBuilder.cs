using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 怪物生成点挂载的脚本, 负责每timeCount生成一只冲向玩家当前位置的怪物,玩家碰撞后会死亡.
/// </summary>
public class skullBuilder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject skull;
    private float timeCount;
    void Start()
    {
        BuildSkull();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount > 2)
        {
            BuildSkull();
            timeCount = 0;
        }
    }

    public void BuildSkull()
    {
        GameObject obj = GameObject.Instantiate(skull);
        skull.transform.position = this.transform.position;
    }
}
