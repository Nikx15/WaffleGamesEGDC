using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public GameObject door;
    public GameObject Bullet;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            source.PlayOneShot(clip);
            door.SetActive(false);
        }
        else
        {
            door.SetActive(true);
        }
    }
}
