using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    Canvas canvas;
    int score;
    Vector2 firstClick;
    Vector2 secondClick;
    Vector2 firstAndSecond;
    float force;
    float degree;
    public TextMeshProUGUI text;
    Vector3 mousePos;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        score = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            firstClick = new Vector2(mousePos.x, mousePos.y);   
        }
        if (Input.GetMouseButtonUp(0))
        {
            rb2D.velocity = Vector2.zero;
            mousePos = Input.mousePosition;
            secondClick = new Vector2(mousePos.x, mousePos.y);
            firstAndSecond = new Vector2(firstClick.x-secondClick.x,firstClick.y-secondClick.y);
            degree = (Mathf.Atan2(firstAndSecond.y,firstAndSecond.x)*Mathf.Rad2Deg);
            force = Vector2.Distance(firstClick,secondClick)* 0.75f;

            Vector3 direction = Quaternion.AngleAxis(degree, Vector3.forward) * Vector3.right;
            rb2D.AddForce(direction * force);
            score++; 
            text.text = score.ToString();
            
        }
    }
}
