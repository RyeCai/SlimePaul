using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileDamageController : MonoBehaviour
{
    [SerializeField] private float anyDamage;
    [SerializeField] public MobileHealthController healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("f");
            Damage();
        }
    }

    public void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - anyDamage;
        healthController.UpdateHealth();
        
    }
}
