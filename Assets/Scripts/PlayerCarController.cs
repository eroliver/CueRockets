using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
    private Rigidbody playerRB;
    private float movementSpeed = 5f;
    private float rotationAmount = 50f;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(movementSpeed);
    }

    private void MovePlayer(float moveSpeed)
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRB.AddForce(transform.forward * moveSpeed);
        }

        //transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);
        //transform.Rotate(0, Input.GetAxis("Horizontal") * rotationAmount * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerRB.AddTorque(transform.up * (rotationAmount * Time.deltaTime));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerRB.AddTorque(transform.up * (-rotationAmount * Time.deltaTime));
        }

        // This should be set to degrees per second float rotationAmount = 90.0f;

        // Clamps automatically angles between 0 and 360 degrees. transform.Rotate (0, rotationAmount * Time.deltaTime, 0); } 
    }   
}
