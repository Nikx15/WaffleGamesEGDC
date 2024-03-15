using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shortenPlayer : MonoBehaviour
{
    public bool isShort = false;
    public GameObject body;

    // Start is called before the first frame update
    void Start()
    {

    }

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

            if (isShort == true)
            {
                
            }
        }
    }
}
