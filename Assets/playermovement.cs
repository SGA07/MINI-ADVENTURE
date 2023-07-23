using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    public float movespeed = 5f;
    public Rigidbody2D mybody;
    public float verticalForce = 5f;
    private bool isgrounded = true;
    private float movex;
    public Animator anim;
    private string Run_animation = "run";
    public GameObject pp;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        playerjump();
        playermove();
        playeranimator();
        if (transform.position.y < -10)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("levelselector");
        }
    }
    void playermove()
        {
        movex = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movex,0f,0f) * Time.deltaTime * movespeed;
        }
    
    void playerjump()
    {
        if (Input.GetButtonDown("Jump") && isgrounded==true)
        {
            isgrounded = false;
            mybody.AddForce(new Vector2(0f, verticalForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isgrounded = true;
        //if (collision.gameObject.CompareTag("Flag"))
           // SceneManager.LoadScene("mainmenu");

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Die();
        }
        if (collision.gameObject.CompareTag("Flag"))
            SceneManager.LoadScene("levelselector");




    }


       
            



            
        
    
    private void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("levelselector");
    }
   void playeranimator()
    {
        if (movex > 0)
        {
            anim.SetBool(Run_animation, true);
        }
        else if (movex < 0)
        {
            anim.SetBool(Run_animation, true);
        }
        else
        {
            anim.SetBool(Run_animation, false);
        }
    }











}   
    
