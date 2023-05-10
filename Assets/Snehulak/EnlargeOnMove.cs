using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeOnMove : MonoBehaviour
{
    public float distanceToEnlarge = 1f; // Vzd�lenost, po kter� se m� objekt zv�t�it
    public float scaleFactor = 1.1f; // Faktor zv�t�en� objektu

    private Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        if ((transform.position - lastPosition).magnitude >= distanceToEnlarge)
        {
            transform.localScale *= scaleFactor;
            lastPosition = transform.position;
        }
    }
}







