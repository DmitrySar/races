using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] cars;
    private GameObject car;
    private float time;
    [SerializeField] private int direct = -1;
    [SerializeField] private float angle = 180f;
    void Start()
    {
        
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            car = cars[Random.Range(0, 3)];
            car = Instantiate(car, new Vector3(
                Random.Range(direct * 3, 0),
                transform.position.y,
                -5f),
                Quaternion.Euler(angle, 0f, 0f));
            car.tag = "Enimy";
            car.GetComponent<Rigidbody2D>().velocity =
                new Vector2(0, Random.Range(2f, 7f) * direct);
            Destroy(car, 10f);
            InitTime();
        }
    }

    private float InitTime()
    {
        time = Random.Range(2f, 10f);
        return time;
    }
}
