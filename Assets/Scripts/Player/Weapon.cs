using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Weapon : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce = 20f;

    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public Weapon weapon;
    Vector2 mousePosition;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        //GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);

        //everything here and below is the mouse directed shooting mechanic

        //ProcessInputs();
    }

   /* 
    void FixedUpdate()
    {
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }

    void ProcessInputs()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }*/
}
