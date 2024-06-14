using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            Box box = other.GetComponent<Box>();
            if (box != null)
            {
                Debug.Log("FUCK YOU");
                box.Explode();
            }
            Destroy(gameObject);
        }
    }
        public void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject); //if not player
        }

}
