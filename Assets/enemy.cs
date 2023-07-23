using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    private bool movingright;
    public Transform grounddetection;
    void Start()
    {
      if (transform.position.y < -30)
        {
            Destroy(this.gameObject);
        }  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundinfo = Physics2D.Raycast(grounddetection.position, Vector2.down, 2f);
        if (groundinfo.collider == false)
        {
            if (movingright == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingright = false;
            }else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingright = true;
            }
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    
        
    










}

