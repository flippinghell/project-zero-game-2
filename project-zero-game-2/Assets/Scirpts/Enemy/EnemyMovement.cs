using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private Transform self;
    public GameObject player;
    private Rigidbody2D physics;
    public float force = 10f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        target = player.GetComponent<Transform>();
        self = GetComponent<Transform>();
        physics = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = target.position.x - self.position.x;
        float y = target.position.y - self.position.y;


        physics.AddForce(new Vector2(x, y) / Mathf.Sqrt(x*x + y*y) * force);

        print("my force vector to target is (" + x + ", " + y + ").");
        
    }
}
