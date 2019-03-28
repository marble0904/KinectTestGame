using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigGorillaController : MonoBehaviour {

    private Vector3 upVec = new Vector3(0,1,0);
    private int upcount = 0;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void up()
    {
        transform.position += transform.forward * 1.0f;
        upcount++;
        if(upcount == 20)
        {
            GameObject.Find("ImokenpiController").GetComponent<ImokenpiController>().Play();
        }
    }

    public void down()
    {
        transform.position -= transform.forward * 1.0f;
        upcount -= 1;
    }

}
