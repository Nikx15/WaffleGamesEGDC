using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public GameOver GameOver;

    public float TimeLeft;
    public bool TimerOn = false;
    //public GameObject lose;

    public TextMeshProUGUI TimerTxt;

    // Start is called before the first frame update
    void Start()
    {
        
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
                //lose.SetActive(false);
            }
            else
            {
                Debug.Log("Time is UP!");
                GameOver.GameOverOn();
                // game over screen/restart
                TimeLeft = 0;
                TimerOn = false;
                Time.timeScale = 0f;
                //lose.SetActive(true);
                //restart button
            }
        }
    }

    void updateTimer(float currentTime)
    {
        //currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
