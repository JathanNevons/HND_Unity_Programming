using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int score = 10;
    void Start()
    {
        int lives = 3;
        Debug.Log(score);
        Debug.Log(lives);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        //Debug.Log(lives);
    }
}
