using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour 
{

    //public LineRenderer lineRenderer;
    //public Transform LaserHit;

    public float fireRate = 0;
    public float Damage = 10;
    public LayerMask whatToHit;

    float timeToFire = 0;
    Transform firePoint;
    public int damage = 40;

    public GameObject impactEffect;
    
	void Awake () 
    {
        firePoint = transform.Find("FirePoint");

    }

    void Start()
    {
        //lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer.enabled = false;
        //lineRenderer.useWorldSpace = false;
    }

    void Update () 
    {
        if (fireRate == 0)
        {
            if(Input.GetKey(KeyCode.Mouse0))
            {
                Shoot();
            }
        }
        else
        {
            if(Input.GetKey(KeyCode.Mouse0) && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
        //LaserHit.position = hit.point;
        //lineRenderer.SetPosition(0, transform.position);
        //lineRenderer.SetPosition(1, LaserHit.position);
        //if (Input.GetKey(KeyCode.Mouse0))
        //{
        //    lineRenderer.enabled = true;
        //}
        //else
        //{
        //    lineRenderer.enabled = false;
        //}

    }

    void Shoot ()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hitInfo = Physics2D.Raycast(firePointPosition, mousePosition-firePointPosition, 100, whatToHit);
        //Debug.DrawLine(firePointPosition, (mousePosition - firePointPosition) * 100, Color.cyan);
        //if (hitInfo.collider != null)
        //{
        //    Debug.DrawLine(firePointPosition, hitInfo.point, Color.red);
        //}

        if (hitInfo)
        {
            Enemy0 enemy = hitInfo.transform.GetComponent<Enemy0>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Instantiate(impactEffect, hitInfo.point, Quaternion.identity);

        }
    }
}
