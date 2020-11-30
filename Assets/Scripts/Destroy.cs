using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float timer;
    public GameObject destroyer;
    public GameObject destroyer2;

    public float TimeBoss;
    public GameObject spawn;

    void Start()
    {
        Invoke("SpawnBoss", TimeBoss);   
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Touché");

            Destroy(destroyer, timer);
            Destroy(destroyer2, timer);
        }
    }
}
