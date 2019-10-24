using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float moveSpeed = 20f;

    Rigidbody2D rb;

    PlayerMovement Target;

    Vector2 moveDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Target = GameObject.FindObjectOfType<PlayerMovement>();
        rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
        rb.AddForce(Vector2.down * moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player")){
            Debug.Log("hit!");
            Destroy(gameObject);
        }
    }
}
