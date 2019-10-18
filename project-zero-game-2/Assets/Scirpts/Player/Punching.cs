using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punching : MonoBehaviour
{
    public Transform PunchRPoint;
    public GameObject FistRprefab;

    public float FistRForce = 20f;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            PunchR();
        }
    }

    void PunchR()
    {
        GameObject FistR = Instantiate(FistRprefab, PunchRPoint);
        Rigidbody2D rb = FistR.GetComponent<Rigidbody2D>();
        rb.AddForce(PunchRPoint.up * FistRForce, ForceMode2D.Impulse);
    }
}
