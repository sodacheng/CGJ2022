using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
