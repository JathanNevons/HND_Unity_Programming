using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTarget : MonoBehaviour
{
    [SerializeField] private GameObject target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            target.SetActive(false);
        }
    }
}
