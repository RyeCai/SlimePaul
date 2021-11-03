using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeedHigh;
    public float bulletSpeedLow;
    public float bulletAngle;
    public float bulletTorqueAngle;
    Rigidbody2D bulletRB;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        bulletRB.AddForce(new Vector2(Random.Range(-bulletAngle, bulletAngle), Random.Range(bulletSpeedLow, bulletSpeedHigh)), ForceMode2D.Impulse);
        bulletRB.AddTorque((Random.Range(-bulletTorqueAngle, bulletTorqueAngle)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
