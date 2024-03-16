using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shortenPlayer : MonoBehaviour
{
    public bool isShort = false;
    public GameObject body;


    // Update is called once per frame
    void Update()
    {
        shorten();
    }

    void shorten()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (isShort == false)
            {
                isShort = true;
                Instantiate(body, transform.position, transform.rotation);
            }
        }
    }
}
