using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {   PrintInstructions();
        
    }

    // Update is called once per frame
    void Update()
    {   
        MovingPlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to Invasion Evasion");
        Debug.Log("You can use WASD or arrow keys to move");
        Debug.Log("This is an obstacle course");
    }

    void MovingPlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}
