using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform LaserHit;
    public GameObject Player;

    public MobileDamageController damage;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
        Debug.DrawLine(transform.position, hit.point);
        LaserHit.position = hit.point;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, LaserHit.position);
        if(hit.collider.gameObject.tag == "Player")
        {
            damage.Damage();
        }
        
    }
    
    public void TurnOffLaser()
    {
        lineRenderer.enabled = false;
    }
}
