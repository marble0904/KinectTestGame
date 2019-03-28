using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectTest : MonoBehaviour {

    public GestureListener gl;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gl.IsSwipeRight())
        {
            audioSource.Play();
        }
	}
}
