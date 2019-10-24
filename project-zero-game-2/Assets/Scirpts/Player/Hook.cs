using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public GameObject HookPrefab;
    public Transform PunchRPoint;

    public float HookLaunchForce = 5f;
    public float HookPullForce = 5f;


    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Debug.Log("right clicked");
            if (GameObject.FindGameObjectWithTag("HookTag") == null)
            {
                Hooking();
            }
        }
        void Hooking()
        {
            GameObject Hook = Instantiate(HookPrefab, PunchRPoint);
            Rigidbody2D rb = Hook.GetComponent<Rigidbody2D>();
            rb.AddForce(PunchRPoint.up * HookLaunchForce, ForceMode2D.Impulse);


        }
    }

    
}
