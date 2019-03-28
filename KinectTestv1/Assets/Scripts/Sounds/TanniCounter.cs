using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TanniCounter : MonoBehaviour {

    public Text tanniText;
    public Text endText;
    public Text termText;
    public int endCount = 144;
    public AudioSource endSound;

    private float delta;
    public float span = 10f;
    private int term;

    private int tanniCount;
    private int shinchokuCount;
    //private bool mode;

    public GameObject swiper;

    public GameObject tanni;
    public GameObject shinchoku;

	// Use this for initialization
	void Start () {
        tanniCount = 0;
        shinchokuCount = 0;
        delta = 0;
        term = 0;
        //mode = false;
	}
	
	// Update is called once per frame
	void Update () {
        delta += Time.deltaTime;
        if(delta >= span)
        {
            delta = 0;
            term++;
            switch (term)
            {
                case 1:
                    termText.text = "一年後期";
                    break;
                case 2:
                    termText.text = "二年前期";
                    break;
                case 3:
                    termText.text = "二年後期";
                    break;
                case 4:
                    termText.text = "三年前期";
                    break;
                case 5:
                    termText.text = "三年後期";
                    break;
                case 6:
                    if (tanniCount < endCount)
                    {
                        endText.gameObject.SetActive(true);
                        endText.text = "留年確定";
                        Time.timeScale = 0;
                    }
                    else
                    {
                        swiper.SetActive(true);
                        tanni.SetActive(false);
                        shinchoku.SetActive(true);
                        tanniText.text = "進捗" + shinchokuCount + "%";
                        termText.text = "四年前期";
                    }
                    break;
                case 7:
                    termText.text = "四年後期";
                    break;
                default:
                    endText.gameObject.SetActive(true);
                    endText.text = "留年確定";
                    Time.timeScale = 0;
                    break;

            }
        }
	}

    public void TanniPlus()
    {
        tanniCount++;
        tanniText.text = tanniCount + "単位";

    }

    public void ShinchokuPlus()
    {
        shinchokuCount += 10;
        tanniText.text = "進捗" + shinchokuCount + "%";
        if (shinchokuCount == 100)
        {
            endText.gameObject.SetActive(true);
            endSound.Play();
            Time.timeScale = 0;
        }
    }
}
