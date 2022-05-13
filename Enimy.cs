using System;
using UnityEngine;

public class Enimy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameController.StopGame();
        }
    }
}
