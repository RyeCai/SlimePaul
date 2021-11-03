using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float fallDelay;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Invoke("DropPlatform", fallDelay);
            
        }
        if(col.gameObject.tag == "Platform")
        {
            Destroy(this.gameObject);
        }

    }

    void DropPlatform()
    {
        rb2d.isKinematic = false;
    }
    
    
}
