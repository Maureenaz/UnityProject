using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timeBtwShot;
    public float StartTimeBtwShot;
    public GameObject projectiles;
    // Start is called before the first frame update
    void Start()
    {
        timeBtwShot = StartTimeBtwShot;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShot <= 0)
        {
            Instantiate(projectiles, transform.position,Quaternion.identity);
            timeBtwShot = StartTimeBtwShot;
        }
        else
        {
            timeBtwShot -= Time.deltaTime;
        }
    }
}
