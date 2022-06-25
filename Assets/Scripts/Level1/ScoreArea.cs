using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public Lesson1Panel panel;
    private int num = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            ++num;
            panel.UpdateScore(num);
            Debug.Log("得分");
        }
    }
}
