using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float spawnTime;
    public float spawnStart;

    public int OeilVolant;

    public GameObject[] ennemy;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("spawn");

           StartCoroutine(coroutine());
        }
    }

    IEnumerator coroutine()
    {
        while (true)
        {
            Debug.Log("start coroutine at : " + Time.time);

            for (int i = 0; i < OeilVolant; i++)
            {
                int OeilIndex = Random.Range(0, ennemy.Length);
                Instantiate(ennemy[OeilIndex], transform.position, transform.rotation);

                yield return new WaitForSeconds(5);
                Debug.Log("Spawn);
            }
        }
    }

    //void spawn()
    //{
    //    OeilVolant = Random.Range(0, ennemy.Length);
    //    Instantiate(ennemy[OeilVolant, transform.position, transform.rotation]);
    //}
}
