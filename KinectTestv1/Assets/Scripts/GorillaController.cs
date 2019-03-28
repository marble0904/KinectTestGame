using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GorillaController : MonoBehaviour {

    //public Rigidbody rb;
    public float speed = 0.1f;
    private bool clear;
    public float span1 = 0.5f;
    public float span2 = 2.0f;
    public float span3 = 20.0f;
    private float delta = 0f;
    public GameObject clearObject;
    public bool playSound = false;

	// Use this for initialization
	void Start () {
      clear = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(clear == true)
        {
            delta += Time.deltaTime;
            if(delta >= span1 && !playSound)
            {
                playSound = true;
                GameObject.Find("GorillaSound").GetComponent<AudioSource>().Play();
            }

            if (delta >= span2)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
                clearObject.SetActive(true);
            }

            if(delta >= span3)
            {
                //SceneNavigator.Instance.ChangeScene("MainMenu", fadeDuration: 8, fadeDelay: 0);
                SceneManager.LoadScene("MainMenu");
            }

        }
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Warabimochi")
        {
            clear = true;
        }
    }
}
