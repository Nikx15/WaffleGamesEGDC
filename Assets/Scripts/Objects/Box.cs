using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public void Explode()
    {
        Destroy(gameObject);
    }
}
