using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotate : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHrizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, moveHrizontal * speed, 0);
    }
}
