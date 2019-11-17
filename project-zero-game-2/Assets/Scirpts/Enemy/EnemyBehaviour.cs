using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject player;
    private EnemyMovement movement;
    private PlayerBehaviour PlayerBehaviour;
    public int EnemyHealth = 2;
    public GameObject fist;
    

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
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("fist"))
        {
            TakeDamage();
            print("damaged");
        }
    }
    void TakeDamage()
    {
        EnemyHealth--;

        if (EnemyHealth <= 0)
            Death();
    }

    void Death()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

