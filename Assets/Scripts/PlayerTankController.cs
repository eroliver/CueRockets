using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankController : MonoBehaviour
{
    [SerializeField]
    private GameObject ammunition;
    
    private Rigidbody playerRB;
    private float movementSpeed;
    private float rotationSpeed;
    private Transform ammunitionTrans;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        movementSpeed = 10f;
        rotationSpeed = 10f;
        ammunitionTrans = ammunition.transform;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    public void PlayerInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRB.AddForce(transform.forward * movementSpeed);
        }
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            playerRB.AddRelativeTorque(transform.up * rotationSpeed * Input.GetAxisRaw("Horizontal"));
        }

        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }

    private static void Shoot()
    {
    }
}
