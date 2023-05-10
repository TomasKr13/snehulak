using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest2D : MonoBehaviour
{
    private SpriteRenderer rend;

    [SerializeField]
    private Sprite openedChest;
    [SerializeField]
    private Sprite closedChest;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    void Update()
    {
        
    }
}
