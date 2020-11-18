using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public GameObject gameOverUI;
    public static bool gameIsPaused;

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameIsPaused = false;
        Time.timeScale = 1f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "FinalsTrophy")
        {
            movement.enabled = false;
            gameOverUI.SetActive(true);
            Time.timeScale = 0;
            gameIsPaused = true;
        }
    }
}
