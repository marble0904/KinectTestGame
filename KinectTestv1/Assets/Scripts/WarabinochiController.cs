using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarabinochiController : MonoBehaviour {

    public float span = 30.0f;
    public float delta;

    //public AudioClip auWall;
    //public AudioClip 
    //public AudioSource audioSource;
    //public GameObject soundController; 
    //public SoundController soundController;

    // Use this for initialization
    void Start () {
        delta = 0;
	}
	
	// Update is called once per frame
	void Update () {
        delta += Time.deltaTime;
        if(delta >= span)
        {
            Destroy(gameObject);
        }
	}

    /*
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Wallaby")
        {
            //audioSource.Play();
            soundController.Wallaby();
            Destroy(col.gameObject);
        }
    }
    */
}
