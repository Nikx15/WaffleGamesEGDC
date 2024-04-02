using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //GameOver when
    //Player loses all hp
    //Timer runs out
    //(is that all?? ask matthew)

    public void GameOverOn()
    {
        gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
