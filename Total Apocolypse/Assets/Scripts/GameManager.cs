using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public PlayerController playerController;

    public TextMeshProUGUI healthText;
    public float health = 100.0f;
    public bool isGameActive;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        health = playerController.health;

        UpdateHealth();
    }

    void UpdateHealth()
    {
        healthText.gameObject.SetActive(true);
        healthText.text = "Health: " + health;
    }
}
