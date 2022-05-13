using UnityEngine;

public class CanisterController : MonoBehaviour
{
    [SerializeField] private GameObject canister;
    private float startTime = 5f;
    private float endTime = 20f;
    private float currentTime;

    private void InitTime()
    {
        currentTime = Random.Range(startTime, endTime);
    }
    void Start()
    {
        InitTime();
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime < 0)
        {
            Instantiate(canister, new Vector3(
                    Random.Range(-GameController.LimitX, GameController.LimitX),
                    transform.position.y,
                    -2f),
                transform.rotation);
            InitTime();
        }

    }
}
