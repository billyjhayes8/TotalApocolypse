using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will be used for enemies which move vertically 
public class Zombie : MonoBehaviour
{
    //Variables
    public float speed = 2.0f, xMin, xMax, zMin, zMax, yPos = 0.25f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        //Spawn the enemy in a random position within the specified range
        transform.position = new Vector3(Random.Range(xMin, xMax), yPos, Random.Range(zMin, zMax));
    }

    // Update is called once per frame
    void Update()
    {
            MoveVertical();
    }

    void MoveVertical()
    {
        //Move the enemy back and forth along the x axis
       transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 3), transform.position.y, transform.position.z);
    }

    /* MOVE HORIZONTAL AUTO CODE
    
    void MoveHorizontal()
    {
       transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * speed, 3));
    }

    */

    /* MOVE DIAGONAL AUTO CODE
     
    void MoveDiagonal()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 3), transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * speed, 3));
    }

    */
}
