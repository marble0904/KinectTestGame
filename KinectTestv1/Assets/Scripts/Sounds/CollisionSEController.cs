using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSEController : MonoBehaviour {

    public AudioSource audioSource;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "foot")
        {
            audioSource.Play();
        }
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Foot")
        {
            audioSource.Play();
        }
    }
}
