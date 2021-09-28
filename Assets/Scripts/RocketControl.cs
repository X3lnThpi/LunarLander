using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RocketControl : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public Rigidbody2D rb2D2;
    public float ThrustersForce;
    public float ThrustersForceIndividual;
    public ParticleSystem ps1;
    public ParticleSystem ps2;
    //public GameObject LeftRocket;
    // public GameObject RightRocket;
    // Start is called before the first frame update
    void Start()
    {
        //ParticleSystem PS = GetComponent<ParticleSystem>();
        //var em = PS.emission;
        //em.enabled = true;
        //em.rateOverTime = 20.0f;

        //em.SetBursts(
        //    new ParticleSystem.Burst[]{
        //        new ParticleSystem.Burst(2.0f, 100),
        //        new ParticleSystem.Burst(4.0f, 100)
        //    });

        //ps1 = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        // LeftRocket.GetComponent<Physics2D>();
        //rb2D = gameObject.AddComponent<Rigidbody2D>();

 

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A Pressed");
            //rb2D.AddForce(transform.up * ThrustersForce, ForceMode2D.Impulse);
            rb2D.AddRelativeForce(transform.up * ThrustersForceIndividual, ForceMode2D.Impulse);

        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D Pressed");
            //rb2D2.AddForce(transform.up * ThrustersForce, ForceMode2D.Impulse);
            rb2D2.AddRelativeForce(transform.up * ThrustersForceIndividual, ForceMode2D.Impulse);
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddRelativeForce(transform.up * ThrustersForce, ForceMode2D.Impulse);
            rb2D2.AddRelativeForce(transform.up * ThrustersForce, ForceMode2D.Impulse);
            ps1.Play();
            ps2.Play();
        }
    }
}
