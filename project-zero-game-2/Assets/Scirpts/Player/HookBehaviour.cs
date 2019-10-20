using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookBehaviour : MonoBehaviour
{
    public GameObject hiteffect;


    void OnCollisionEnter2D(Collision2D Collision)
    {
        Destroy(gameObject);
    }
}
