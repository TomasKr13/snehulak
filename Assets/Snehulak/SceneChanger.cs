using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Player");
            Vector3 maxSize = new Vector3(1.5f, 1.5f, 0);
            if (gameObjects[0].transform.localScale.x < maxSize.x && gameObjects[0].transform.localScale.y < maxSize.y)
            {
                SceneManager.LoadScene(sceneName);
            }

        }
    }
}
