using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] float boostSpeed;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * boostSpeed);
            // Clamp Velocity Speed
        }
    }
}
