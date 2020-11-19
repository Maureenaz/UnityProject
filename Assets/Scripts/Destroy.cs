using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float timer;
    public GameObject destroyer;
    public GameObject destroyer2;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Touché");

            Destroy(destroyer, timer);
            Destroy(destroyer2, timer);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
