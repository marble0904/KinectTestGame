using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinchokuGenerator : MonoBehaviour {

    public double span = 1.0f;
    private double startSpan;
    private double delta;
    public GameObject shinchoku;
    public Rigidbody rb;
    public Transform spawnpoint;
    public float speed = 3;

    // Use this for initialization
    void Start()
    {
        startSpan = span;
        span = startSpan * Random.Range(0.1f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta >= span)
        {
            delta = 0;
            span = startSpan * Random.Range(0.1f, 1.0f);
            GameObject warabi = Instantiate(shinchoku) as GameObject;
            warabi.transform.position = spawnpoint.position;
            Rigidbody rb = warabi.GetComponent<Rigidbody>();
            rb.velocity = spawnpoint.forward * speed;
        }
    }
}
