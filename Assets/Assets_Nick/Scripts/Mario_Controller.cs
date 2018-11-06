using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario_Controller : MonoBehaviour {

    public float MoveSpeed;
    public float JumpForce;

    private Rigidbody rb;
    private Vector3 inputVector;
    private Vector3 jumpVector;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        jumpVector = new Vector3(0.0f, 10.0f, 0.0f);
    }

    private void Update()
    {
        UpdateMovement();
        UpdateJump();
    }

    private void UpdateMovement()
    {
        float moveVelocity_X = MoveSpeed * Input.GetAxis("Horizontal");
        float moveVelocity_Z = MoveSpeed * Input.GetAxis("Vertical");

        rb.velocity = new Vector3(moveVelocity_X, rb.velocity.y, moveVelocity_Z);



        /*float hoz = MoveSpeed * Input.GetAxis("Horizontal");
        float vert = MoveSpeed * Input.GetAxis("Vertical");

        inputVector = new Vector3(hoz, 0f, vert);

        if (inputVector != Vector3.zero)
        {
            this.transform.rotation = Quaternion.LookRotation(inputVector);
        }*/


    }

    private void UpdateJump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Jump!");
            rb.velocity = Vector2.up * JumpForce;


            //rb.AddForce(jumpVector * JumpForce, ForceMode.Impulse);
            //isGrounded = false;

        }
    }

    private void FixedUpdate()
    {
        //rb.velocity = inputVector;
        //rb.velocity += jumpVector;
    }

}
