using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public int PlayerHealth;
    public bool PlayerContact = false;
    private EnemyBehaviour enemybehaviour;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = 5;
        enemybehaviour = enemy.GetComponent<EnemyBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        print(PlayerHealth);

        if (PlayerContact
            && enemybehaviour.EnemyContact)
        {
            PlayerHealth--;
            PlayerContact = false;
            enemybehaviour.EnemyContact = false;
        }

            
    }

    void OnTriggerEnter2D()
    {
        PlayerContact = true;
    }
}
