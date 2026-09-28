using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organise_Script : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 5f;
    [SerializeField] private float rotateSpeed = 90f;
    [SerializeField] private float sprintSpeed = 50f;
    void Update()
    {
        HandleMovement();
        HandleRotation();
    }
    
    void HandleMovement()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back* MoveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.forward * sprintSpeed * Time.deltaTime);
    }

    void HandleRotation()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, rotateSpeed* Time.deltaTime, 0);
    }
}
