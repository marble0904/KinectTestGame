using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImokenpiController : MonoBehaviour {

    public GameObject imokenpiSound;
    public GameObject imokenpiParticle;

    private bool flag = false;
    public float span = 2.0f;
    public float delta = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (flag)
        {
            delta += Time.deltaTime;
            if (delta >= span)
            {
                imokenpiSound.SetActive(true);
                imokenpiParticle.SetActive(true);
            }
        }
	}

    public void Play()
    {
        flag = true;

    }
}
