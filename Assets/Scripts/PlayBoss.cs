using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBoss : MonoBehaviour
{
    public Animator BossAnim;

    // Start is called before the first frame update
    void Start()
    {
        BossAnim = GetComponent<Animator>();

        BossAnim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D colli)
    {
        if (colli.collider.CompareTag("Player"))
        {
            Debug.Log("Play Boss");

            BossAnim.enabled = true;
        }
    }
}
