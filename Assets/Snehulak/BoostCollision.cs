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

    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Booster"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity *= speedIncrease; // Multiply the current velocity by the speed increase
        }
    }

}
