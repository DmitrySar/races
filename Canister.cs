using UnityEngine;

public class Canister : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Gasoline.AddGasoline();
            Destroy(gameObject);
        }
    }
}
