using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    private Rigidbody2D physics;
    public float force = 10;

    // Start is called before the first frame update
    void Start()
    {
        physics = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            physics.AddForce(Vector2.up * force);
        if (Input.GetKey(KeyCode.S))
            physics.AddForce(Vector2.down * force);
        if (Input.GetKey(KeyCode.A))
            physics.AddForce(Vector2.left * force);
        if (Input.GetKey(KeyCode.D))
            physics.AddForce(Vector2.right * force);
    }
}
