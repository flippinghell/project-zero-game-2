﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private Transform trans;
    public bool PositionPrint;
    void Start()
    {
        trans = GetComponent<Transform>();
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        if(Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(PositionPrint)
            print(trans.position);
    }
}
