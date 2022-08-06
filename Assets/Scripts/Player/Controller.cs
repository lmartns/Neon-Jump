using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveInput;
    private float speed = 10f;

    private float topScore = 0.0f;

    public Text scoreText;

    private float inputHorizontal = 0;
 

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        
        if(rb.velocity.y > 0 && transform.position.y > topScore)
        {

            topScore = transform.position.y;

        }

        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();

    }

    void FixedUpdate()
    {
     
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }

    public void SetInputHoziontal(float valor)
    {

        inputHorizontal = valor;

    }
}
