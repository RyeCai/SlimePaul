using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenDeath : MonoBehaviour
{
    [SerializeField] public GameObject deathAni;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy") { 
            GameObject death = Instantiate(deathAni) as GameObject;
            death.transform.position = transform.position;
            Destroy(other.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
