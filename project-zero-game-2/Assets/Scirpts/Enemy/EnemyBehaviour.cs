using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject player;
    private EnemyMovement movement;
    public float speed = 15f;
    public int time = 8;
    private int a;
    public bool EnemyContact = false;

    // Start is called before the first frame update
    void Start()
    {
        // accessing the enemy's own movement script to get the contact force direction
        movement = GetComponent<EnemyMovement>();
        a = time;
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("target hit!");

        a = 0;
        EnemyContact = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a < time)
        {
            a++;
            
        }

    }

    
}

