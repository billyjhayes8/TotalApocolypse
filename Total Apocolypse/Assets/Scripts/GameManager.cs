using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Variables
    public PlayerController playerController;
    public GameObject gameOverPanel;
    public GameObject startPanel;
    public Button restartButton;
    public TextMeshProUGUI healthText;
    public float health = 100.0f;
    public bool isGameActive = false;

    private void Start()
    {
        //Starts the game before the first frame
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        //sets the UI health variable to the same value as the playerController health
        health = playerController.health;

        UpdateHealth();

        if (health <= 0)
        {
            isGameActive = false;
        }
    }

    //This updates the health on the UI
    void UpdateHealth()
    {
        healthText.gameObject.SetActive(true);
        healthText.text = "Health: " + health;
    }

    //If the restart button is clicked, this will reload the scene and restart the game
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameActive = true;
    }

    //Once the game is over, this will bring up the game over panel
    public void GameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
        isGameActive = false;
    }

    // At the beginning of the game, this will bring up the start game panel
    public void StartGame()
    {
        startPanel.gameObject.SetActive(true);
    }

    // Once Start Game button is clicked, this will get rid of the start game panel
    public void setIsGameActiveTrue()
    {
        isGameActive = true;
        startPanel.gameObject.SetActive(false);
    }
}
