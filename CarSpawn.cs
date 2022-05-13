using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] cars;
    [SerializeField] private float angle = 180f;
    [SerializeField] private float direct = -1f;
    private GameObject car;
    private float currentTime;
    private float startTime = 2f;
    private float endTime = 7f;
    private float minSpeed = 5f;
    private float maxSpeed = 20f;
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime < 0)
        {
            car = cars[Random.Range(0, cars.Length)];
            car = Instantiate(car, new Vector3(Random.Range(direct * GameController.LimitX, 0),
                transform.position.y,
                -2f),
                Quaternion.Euler(angle, 0f, 0f));
            car.tag = "Enimy";
            car.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,  direct * Random.Range(minSpeed, maxSpeed));
            Destroy(car, 10f);
            InitTime();
        }
    }

    private void InitTime()
    {
        currentTime = Random.Range(startTime, endTime);
    }
}
