using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarabimochiGenerator : MonoBehaviour {
    public double span = 1.0f;
    private double delta;
    public GameObject warabimochi;
    public Rigidbody rb;
    public Transform spawnpoint;
    public float speed = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        delta += Time.deltaTime;
        if(delta >= span)
        {
            delta = 0;
            GameObject warabi = Instantiate(warabimochi) as GameObject;
            warabi.transform.position = spawnpoint.position;
            Rigidbody rb = warabi.GetComponent<Rigidbody>();
            rb.velocity = spawnpoint.forward * speed;
        }
	}
}
