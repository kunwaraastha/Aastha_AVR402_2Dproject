using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    gameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<gameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.coinAdder();
            Destroy(gameObject);
        }
    }
}