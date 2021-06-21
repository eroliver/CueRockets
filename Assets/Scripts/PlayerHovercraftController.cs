using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHovercraftController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    private float turnSpeed = 5;
    Rigidbody playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Rotate();
    }

    void Run()
    {
        if (Input.GetKey(KeyCode.W))
        { playerRigidbody.AddForce(speed * transform.forward); }
        if (Input.GetKey(KeyCode.S))
        { playerRigidbody.AddForce(speed * -transform.forward); }
        if (Input.GetKey(KeyCode.A))
        { playerRigidbody.AddForce(speed * -transform.right); }
        if (Input.GetKey(KeyCode.D))
        { playerRigidbody.AddForce(speed * transform.right); }
    }

    void Rotate()
    {
        var horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(horizontal * turnSpeed * Vector3.up, Space.World);
    }
}
