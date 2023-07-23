using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform playertransform;

    void Start()
    {
        playertransform = GameObject.FindGameObjectWithTag("Player").transform; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!playertransform)
            return;

        Vector3 temp = transform.position;
        temp.x = playertransform.position.x;
        temp.y = playertransform.position.y;
        transform.position = temp;

    }
}
