using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,3f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(transform.right * (-1 * moveSpeed * Time.deltaTime));
    }
}
