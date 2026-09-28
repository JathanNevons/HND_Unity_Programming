using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotateSpeed = 90f;

     void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.Translate(Vector3.down *moveSpeed * Time.deltaTime);
    }


}
