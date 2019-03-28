using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangarooController : MonoBehaviour {

    public float span = 10;
    public float delta = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        delta += Time.deltaTime;
        if (delta >= span)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Warabimochi")
        {
            GameObject.Find("KangarooSound").GetComponent<AudioSource>().Play();
            GameObject.Find("GorillaBig").GetComponent<BigGorillaController>().down();
            Destroy(gameObject);
            GameObject.Find("GameController").GetComponent<GameController>().wallabyPoint -= 100;
        }
    }
}
