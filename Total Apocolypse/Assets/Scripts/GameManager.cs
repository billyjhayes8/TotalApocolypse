using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    private int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;

        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateHealth()
    {
        int damage = 10;

        health -= damage;

        healthText.text = "Health: " + health;
    }


}
