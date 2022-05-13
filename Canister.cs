using System;
using UnityEngine;

public class Canister : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Gasoline.AddGasoline();
            Destroy(gameObject);
        }
    }
}
