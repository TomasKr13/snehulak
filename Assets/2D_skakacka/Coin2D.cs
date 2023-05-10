using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin2D : MonoBehaviour
{
    
    [SerializeField]
    int a;
    [SerializeField]
    int b;
    [SerializeField]
    int c;

    [SerializeField]
    GameObject menicBarvy;

    private void OnTriggerEnter2D(Collider2D col)
    {
        var move = col.GetComponent<Movement2D>();
        if (move != null)
        {
           menicBarvy.GetComponent<Renderer>().material.color = new Color(a, b, c);
            move.Addpoint();
        }
    }
    

}
