using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanges : MonoBehaviour
{
    public float speed = 0.003f;
    public float launchforce = 200;

    float rotateSpeed = 0.2f;

    public Rigidbody rigid;
    float rotatingtime = 0;

    public float fallingspeed = 7.0f;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    { if (Time.time - rotatingtime > 1f)
    { rotateSpeed = rotateSpeed *-1;
    rotatingtime = Time.time;


    }
        {gameObject.transform.Rotate(0, rotateSpeed, 0);

        if (Input.GetKeyDown(KeyCode.Space)) {
            rigid.useGravity = true;
            rigid.AddForce(gameObject.transform.forward * launchforce);
            transform.Translate(Vector3.down * fallingspeed * Time.deltaTime, Space.World);
        }

    
    }
     void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "hittem")
        {col.gameObject.GetComponent<Renderer>().material.color = Color.blue; }
        
    }
}}
