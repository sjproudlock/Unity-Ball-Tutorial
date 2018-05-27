using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    public float speed; 

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveH,0.0f,moveV);

        
        rb.AddForce (movement * speed);

    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
