using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{

    Rigidbody rb;

    float mvmntSpeed = 15;
    private float movX;
    private float movY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 speed = new Vector3(movX * mvmntSpeed, rb.velocity.y, movY * mvmntSpeed);
        rb.velocity = speed;
    }

}
