using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    /*
    public GameObject warabimochi;
    public Rigidbody rbWarabi;
    public Transform spawnpoint;
    public float speed = 3.0f;
    */

    public GameObject player;

    public GameObject wallaby;
    public GameObject kangaroo;

    private float span = 1.0f;
    private float delta;

    public int wallabyPoint = 0;

    public Text pointText;
    public float textDelta = 0;

    // Use this for initialization
    void Start () {
        delta = 0f;
	}
	
	// Update is called once per frame
	void Update () {


        delta += Time.deltaTime;

        if(delta >= span)
        {
            delta = 0f;
            int i = Random.Range(0, 2);
            GameObject wal;
            if (i == 0)
            {
                wal = Instantiate(wallaby) as GameObject;
            }
            else
            {
                wal = Instantiate(kangaroo) as GameObject;
            }

            //ランダムな位置に設定
            int x = Random.Range(-21, 20);
            int z = Random.Range(-21, 20);
            wal.transform.position = new Vector3(x, 0, z);

            //ランダムな角度に設定
            int y = Random.Range(0, 360);
            wal.transform.localEulerAngles = new Vector3(-90,y,0);
        }
        if (wallabyPoint < 0)
        {
            wallabyPoint = 0;
        }

        //pointText = GetComponent<Text>();
        
        if (textDelta >= 6.0f)
        {
            pointText.text = "WallabyPoint:" + wallabyPoint;
        }
        else
        {
            textDelta += Time.deltaTime;
        }
    }
}
