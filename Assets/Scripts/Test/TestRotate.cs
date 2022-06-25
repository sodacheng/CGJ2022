using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate : MonoBehaviour
{
    public float a;

    public float rotateSpeed;

    public float rate;

    private Quaternion q;
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (a > 0)
            {
                a -= rate * 5;
            }
            else
            {
                a -= rate;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (a < 0)
            {
                a += rate * 5;
            }
            else
            {
                a += rate;
            }
        }
        

        rotateSpeed += a * Time.deltaTime;
        
        q = Quaternion.AngleAxis(rotateSpeed,Vector3.up);
        this.transform.rotation *= q;
    }
}
