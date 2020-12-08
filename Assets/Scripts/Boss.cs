using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Boss : MonoBehaviour
{
    public int heart;
    public int damage;
    private float timeBtwDamage = 2;
    private Animation anima;

    public Slider heartBar;

    [SerializeField]
    GameObject bullet;
    float fireRate;
    float nextFire;
    // Start is called before the first frame update
    void Start()
    {
        anima = gameObject.GetComponent<Animation>();

        fireRate = 1;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }

        heartBar.value = heart;

        if (heart == 0)
        {
            anima.Play("explosion");
        }
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
