using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollide : MonoBehaviour
{
    public GameObject objectToAppear;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objectToAppear.SetActive(true);
            Destroy(gameObject);
        }
    }
}
