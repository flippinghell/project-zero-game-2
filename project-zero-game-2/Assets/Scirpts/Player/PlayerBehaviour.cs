using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public int PlayerHealth = 5;
    
    private EnemyBehaviour enemybehaviour;
    public GameObject enemy;
    private GameObject player;
    private PlayerMovement3 PlayerMovement;
    private MouseOrientate MouseOrientate;
    private Punching Punching;


    // Start is called before the first frame update
    void Start()
    {
        Punching = GetComponentInParent<Punching>();
        PlayerMovement = GetComponentInParent<PlayerMovement3>();
        MouseOrientate = GetComponentInParent<MouseOrientate>();
        enemybehaviour = enemy.GetComponent<EnemyBehaviour>();

    }

    // Update is called once per frame
    void Update()
    {
        print(PlayerHealth);
        
        
        

            
    }

    public void TakeDamage()
    {
        PlayerHealth--;

        if (PlayerHealth <= 0)
            Dead();
    }

    void Dead()
    {
        PlayerMovement.enabled = false;
        MouseOrientate.enabled = false;
        Punching.enabled = false;
    }

}
