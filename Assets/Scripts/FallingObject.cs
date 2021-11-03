using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] private float anyDamage;
    [SerializeField] public MobileHealthController healthController;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("SlimePaul Base"))
            rb.isKinematic = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("SlimePaul Base"))
        {
            Damage();
        }
        if (collision.gameObject.tag == "Platform")
        {
            Destroy(this.gameObject);
        }
    }
    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - anyDamage;
        healthController.UpdateHealth();
    }
    // Update is called once per frame

}
