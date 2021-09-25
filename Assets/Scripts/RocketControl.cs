using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RocketControl : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public Rigidbody2D rb2D2;
    //public GameObject LeftRocket;
    // public GameObject RightRocket;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LeftRocket.GetComponent<Physics2D>();
        //rb2D = gameObject.AddComponent<Rigidbody2D>();
        rb2D.AddForce(transform.up * 0.001f);
        rb2D2.AddForce(transform.up * 0.001f);
    }
}
