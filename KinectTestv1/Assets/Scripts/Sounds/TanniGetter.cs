using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanniGetter : MonoBehaviour {

    public AudioSource audioSource;
    public TanniCounter tanniCounter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Tanni")
        {
            Destroy(other.gameObject);
            audioSource.Play();
            tanniCounter.TanniPlus();
        }

        if (other.gameObject.tag == "Shinchoku")
        {
            Destroy(other.gameObject);
            tanniCounter.ShinchokuPlus();
            audioSource.Play();
        }
    }
}
