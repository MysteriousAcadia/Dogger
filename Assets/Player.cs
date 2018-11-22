using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 15f;
    public float maxWidth = 5f;
    private Rigidbody2D rb;
    public static int maxScore = 0;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
   
    private void OnCollisionEnter2D()
    {        
        FindObjectOfType<GameManager>().EndGame();

    }
    void FixedUpdate()
    {
        float x = Input.GetAxis ("Horizontal")*Time.fixedDeltaTime*speed;
        float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;
        Vector2 newposition = rb.position + Vector2.right * x+ Vector2.up*y;
        newposition.x = Mathf.Clamp(newposition.x, -maxWidth, maxWidth);
        rb.MovePosition(newposition);

    }
}
