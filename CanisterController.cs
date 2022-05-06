using UnityEngine;

public class CanisterController : MonoBehaviour
{
    [SerializeField] GameObject canister;
    private float time;

    private void Start()
    {
        InitTime();
    }
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Instantiate(canister, new Vector3(
                Random.Range(-3, 3),
                transform.position.y,
                -2f), 
                transform.rotation);
            InitTime();
        }
    }

    private float InitTime()
    {
        time = Random.Range(5f, 20f);
        return time;
    }
}
