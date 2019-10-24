using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed);
        if (gameObject.transform.position.x < -9)
            moveSpeed = -moveSpeed;
        if (gameObject.transform.position.x > 9)
            moveSpeed = -moveSpeed;
    }
}