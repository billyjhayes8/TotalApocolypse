using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script will be used for enemies that move horizontaly 
public class EnemyHorizontal : MonoBehaviour
{
    //Variables
    public float speed = 2.0f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
    }

    //Code which allows enemy to move horizontally automatically
    void MoveHorizontal()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * speed, 3));
    }


}
