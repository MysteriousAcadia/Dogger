﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {
    public 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClickPlayButton(){
        SceneManager.LoadScene("SampleScene");

    }
    public void OnClickQuitButton(){
        Application.Quit();
    }
}
