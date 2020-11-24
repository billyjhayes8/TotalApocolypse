using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 25.0f;
    public float jummpForce = 2.5f;
    public bool isOnGround = true;
    public float health = 100.0f;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float movementHorizontal = Input.GetAxis("Vertical");
        float movementVertical = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);

        playerRb.AddForce(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jummpForce, ForceMode.Impulse);
            isOnGround = false;
            speed = 0.0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            speed = 50.0f;
        }

        if (collision.gameObject.CompareTag("Zombie"))
        {
            health -= 20;
        }
    }
}
