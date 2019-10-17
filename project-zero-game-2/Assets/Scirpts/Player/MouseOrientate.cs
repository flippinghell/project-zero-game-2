using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOrientate : MonoBehaviour
{

    public Rigidbody2D rb;
    public Camera cam;
    Vector2 mousePosition;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        //Input
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    void FixedUpdate()
    {
        //Movement
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
