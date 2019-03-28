using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 0.5f;
    public Rigidbody rb;
    public float force = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * speed;
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }else if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * speed;
        }
	}

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Warabimochi")
        {
            rb.AddForce(transform.up * force);
        }
    }
}
