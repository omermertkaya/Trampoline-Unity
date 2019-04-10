using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    Animator anim;
    public GameObject bouncer;
    public Vector2 velocity;



    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay2D(Collision2D other)
    {
        //Debug.Log("your charater is staying on the trampoline");
        anim.SetBool("isStepped", true);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           // Debug.Log("your charater entred.");

        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Debug.Log("your charater exited.");
            anim.SetBool("isStepped", false);
           

        }
    }
    void Jump()
    {
        bouncer.GetComponent<Rigidbody2D>().velocity = velocity;
    }

}


