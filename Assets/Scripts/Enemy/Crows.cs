using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crows : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 60f;
    public int Respawn;
    public float timer = 5f;

    void Update()
    {
        timer -= 1f * Time.deltaTime; 
        if (timer > 0f)
        {
            transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotateSpeed, 180) - 90);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Respawn);
        }
    }
}
