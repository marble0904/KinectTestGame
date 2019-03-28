using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart()
    {
        //SceneNavigator.Instance.ChangeScene("Stage", fadeDuration: 1, fadeDelay: 5);
        SceneManager.LoadScene("Stage");
    }

    public void GameClear()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
