using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostCollision : MonoBehaviour
{
    public float speedIncrease = 2f; // The amount to increase speed by upon collision

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Booster"))
        {
            if(transform.localScale.y >= 2f)
            {
                transform.localScale /= 2f;
            }
        }
    }

}
