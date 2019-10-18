using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fists : MonoBehaviour
{
    public GameObject hiteffect;
    public float FistDis = 5f;
    void Update()
    {
        if (transform.localPosition.magnitude > FistDis)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
