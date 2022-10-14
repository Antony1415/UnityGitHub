using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    private float movementX, movementY;
    [SerializeField]private float movementSpeed = 10000f;

    void Start()
    {
        //rb = rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
        
        rb.velocity = new Vector3(movementX, movementY, 0) * Time.deltaTime * movementSpeed;
    }
}
