using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private Transform self;
    public GameObject player;
    private Rigidbody2D physics;
    public float force = 40f;
    public bool VectorPrint = false;
    public Vector2 DirectionVector;

    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Player").transform;
        target = player.GetComponent<Transform>();
        self = GetComponent<Transform>();
        physics = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = target.position.x - self.position.x;
        float y = target.position.y - self.position.y;

        // The unit vector in the direction from the enemy to the player
        DirectionVector = new Vector2(x, y) / Mathf.Sqrt(x * x + y * y);

        physics.AddForce(DirectionVector * force);

        if(VectorPrint)
            print("my direction vector to target is (" + x + ", " + y + ").");
        
    }
}
