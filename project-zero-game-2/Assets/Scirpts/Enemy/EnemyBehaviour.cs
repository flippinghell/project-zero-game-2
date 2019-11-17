using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject player;
    private EnemyMovement movement;
    private PlayerBehaviour PlayerBehaviour;
    

    // Start is called before the first frame update
    void Start()
    {
        // accessing the enemy's own movement script to get the contact force direction
        movement = GetComponent<EnemyMovement>();
        PlayerBehaviour = player.GetComponent<PlayerBehaviour>();
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject == player)
        {
            
            PlayerBehaviour.TakeDamage();
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

