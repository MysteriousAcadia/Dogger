using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClickPlayAgainButton(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        Time.fixedDeltaTime *= 1f;

    }
    public void OnClickQuitButton(){

        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
        Time.fixedDeltaTime *= 1f;
    }
}
