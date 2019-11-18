using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject player;
    private GameObject playerHitBox;
    private EnemyMovement movement;
    public float speed = 15f;
    public int time = 8;
    private int a;

    // Start is called before the first frame update
    void Start()
    {
        // accessing the enemy's own movement script to get the contact force direction
        movement = GetComponent<EnemyMovement>();
<<<<<<< Updated upstream
        a = time;
=======
        PlayerBehaviour = player.GetComponent<PlayerBehaviour>();

        Transform playerHurtboxTransform = player.transform.Find("playerhurtbox");
        this.playerHitBox = playerHurtboxTransform.gameObject;
>>>>>>> Stashed changes
    }

    void OnTriggerEnter2D()
    {
<<<<<<< Updated upstream
        Debug.Log("target hit!");

        a = 0;
=======
        if(this.playerHitBox == null)
        {
        }
        if (other.gameObject == this.playerHitBox)
        {
            
            PlayerBehaviour.TakeDamage();
        }
>>>>>>> Stashed changes

        print(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (a < time)
        {
            a++;
            player.transform.Translate(new Vector3(movement.DirectionVector.x, movement.DirectionVector.y, 0) * speed * Time.deltaTime);
            print(player.transform.position);
        }

    }

    
}

