using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Transform sphereCore;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = this.GetComponent<Rigidbody>();
        sphereCore = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRB.AddForce(sphereCore.transform.forward);
        }
    }
}
