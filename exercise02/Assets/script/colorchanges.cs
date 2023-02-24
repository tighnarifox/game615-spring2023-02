using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanges : MonoBehaviour
{
    public float speed = 0.003f;
    public int launchforce = 200;

    float rotateSpeed = 0.2f;

    public Rigidbody rigid;
    float rotatingtime = 0;
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
        {gameObject.transform.Rotate(0, rotatespeed, 0);

        if (Input.GetKeyDown(Keycode.space)) {
            rigid.useGravity = true;
            rigid.AddForce(gameObject.transform.forward * launchForce);
        }

    
    }
     void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "hittem")
        {col.gameObject.GetComponent<Renderer>().material.color = Color.pink; }
        
    }
}}
