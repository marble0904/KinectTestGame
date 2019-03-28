using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarabimochiSpawner : MonoBehaviour {

    public GameObject warabimochi;
    public Rigidbody rbWarabi;
    public Transform spawnpoint;
    public float speed = 3.0f;

    public GameObject player;

    public AudioSource warabiSound;

    //ワサビ
    public AudioSource wasabiSound;
    public GameObject wasabi;
    public Rigidbody rbwasabi;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Random.Range(0,51) == 1)
            {
                //わらび餅を投げる
                GameObject was = Instantiate(wasabi) as GameObject;
                was.transform.position = spawnpoint.position;
                Rigidbody rb = was.GetComponent<Rigidbody>();
                rb.velocity = (player.transform.forward + player.transform.up) * speed * 4.0f;
                //音を再生
                wasabiSound.Play();
            }
            else {
                //わらび餅を投げる
                GameObject warabi = Instantiate(warabimochi) as GameObject;
                warabi.transform.position = spawnpoint.position;
                Rigidbody rb = warabi.GetComponent<Rigidbody>();
                rb.velocity = player.transform.forward * speed;
                //音を再生
                warabiSound.Play();
            }

        }
    }



}
