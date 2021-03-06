﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int scoreCount;

    float moveh;
    float moveV;
    Vector3 movement = new Vector3(moveH, 0.0f, moveV);



    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

        scoreCount = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        

        rb.AddForce (movement * speed);

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);

            scoreCount = scoreCount + 1;
            SetCountText();
            if (scoreCount>1)
            {
                winText.text = "You Win!";
                speed = 0; 
            }
        }



    }

    void SetCountText()
    {
        countText.text = "score is " + scoreCount.ToString ();

       


    }

}
