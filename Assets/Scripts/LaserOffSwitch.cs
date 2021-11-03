using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserOffSwitch : MonoBehaviour
{
    [SerializeField] public GameObject laser;

   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(laser);

        }
        if(collision.CompareTag("Enemy"))
        {
            Destroy(laser);
        }
    }
}
