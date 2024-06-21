using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public void Explode()
    {
        Destroy(gameObject);
        source.PlayOneShot(clip);
    }
}
