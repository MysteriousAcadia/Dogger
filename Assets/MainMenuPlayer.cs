using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPlayer : MonoBehaviour {
    Rigidbody2D rb;
    public float maxWidth = 5f;
    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 newposition = rb.position + Vector2.right * speed;
        newposition.x = Mathf.Clamp(newposition.x, -maxWidth, maxWidth);
        if(newposition.x>=4.7 || newposition.x<=-4.7){
            speed = -speed;
        } 
        rb.MovePosition(newposition);

    }
}
