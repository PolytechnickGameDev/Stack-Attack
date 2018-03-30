using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{

    public float speed;
    public float jump;

    private float gravityForce;
    private Vector3 moveVector;

    private CharacterController ch_controller;
    void Start()
    {
        ch_controller = GetComponent<CharacterController>();

    }
    void Update()
    {
        Move();
    }

    private void Move()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * speed;

        ch_controller.Move(moveVector * Time.deltaTime);
    }

}