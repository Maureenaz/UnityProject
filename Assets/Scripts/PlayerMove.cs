using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private bool isGround;
    public Transform feetPos;
    public LayerMask whatIsGround;
    public float checkRadius;
    public float jumpForce;

    public GameObject obj;

    public GameObject Bullets;
    public Vector2 velocity;
    bool Shoot = true;
    public Vector2 offset = new Vector2(0.4f, 0.1f);
    public float down;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float MoveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveInput * speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("End"))
        {
            Debug.Log("HELLO");
        }
    }

    void Update()
    {
        isGround = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGround == true && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jumpForce;
            Debug.Log("up");
        }

        if (Input.GetKeyDown(KeyCode.Space) && Shoot)
        {
            GameObject go = (GameObject) Instantiate(Bullets,(Vector2) transform.position + offset * transform.localScale.x, Quaternion.identity);
            go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * transform.localScale.x, velocity.y);
        }
    }

    IEnumerable shoot()
    {
        Shoot = false;
        yield return new WaitForSeconds(down);
        Shoot = true;
    }
}
