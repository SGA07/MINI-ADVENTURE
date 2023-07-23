using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercheck : MonoBehaviour
{
    public Rigidbody2D enemy;
    public GameObject ee;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<enemyheadcheck>())
        {
            
            
            ee.GetComponent<Collider2D>().enabled = false;

        }
             
    }
}
