using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour {
    public float slowness = 5f;
    public float timer;
    public GUIStyle scoreFont =new GUIStyle();
    public int lastScore = 0;
    public GameObject gameOverMenu;
    public void Start()
    {
    }
    public void Update()
    {
        timer += Time.deltaTime;
    }

    void OnGUI()
    {
        scoreFont.fontSize = 32;
       // scoreFont.alignment =;
        int timerFinal = (int)timer;
        GUI.Label(new Rect(10, 10, 450, 300), "  Score: " + timerFinal.ToString(),scoreFont);
        GUI.Label(new Rect(10, 54, 450, 300), "  High Score: " + Player.maxScore.ToString(), scoreFont);
    }

    public void EndGame(){
       
        StartCoroutine(RestartLevel());
    }
    IEnumerator RestartLevel(){
        Time.timeScale/=  slowness;
        Time.fixedDeltaTime/= slowness;
        yield return new WaitForSeconds(1/slowness);
        Time.timeScale = 0;
        Instantiate(gameOverMenu);
        gameOverMenu.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       // Time.timeScale =1f ;
       // Time.fixedDeltaTime *= 1f;
        if(timer>Player.maxScore){
            Player.maxScore = (int)timer;
        }
        timer = 0f;
    }
}
