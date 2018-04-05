using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing_Controler : MonoBehaviour
{

    public float speed;
    public float jump;

    public float gravityForce = 0.009815434f;
    private Vector3 moveVector;

    private CharacterController ch_controller;
    void Start()
    {
        ch_controller = GetComponent<CharacterController>();

    }
    void Update()
    {
        Move();
        moveVector.y = moveVector.y * gravityForce;
        ch_controller.Move(moveVector * Time.deltaTime);
        // if (Input.GetKeyDown("space"))
        //    moveVector.z = moveVector.z * -jump;
    }

    private void Move()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * speed;
        moveVector.y = Input.GetAxis("Vertical") * jump;
        ch_controller.Move(moveVector * Time.deltaTime);
    }

}