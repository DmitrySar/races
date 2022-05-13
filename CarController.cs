using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarController : MonoBehaviour
{
    [SerializeField] private GameObject[] cars;
    private Rigidbody2D body;
    private static GameObject car;
    private float limitX = 3.8f;
    private static float speed = 0f;
    private float maxSpeed = 28f;

    public static float Speed
    {
        get => speed;
    }

    public static GameObject Car
    {
        get { return car; }
    }

    void Awake()
    {
        car = cars[Random.Range(0, cars.Length)];
        car = Instantiate(car, transform.position, transform.rotation);
        transform.SetParent(car.transform);
        body = car.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        float axisX = Input.GetAxis("Horizontal");
        float x = Mathf.Clamp(car.transform.position.x + axisX, -limitX, limitX);
        if (axisX != 0)
            car.transform.position = new Vector3(x,
                car.transform.position.y,
                car.transform.position.z);
    }

    private void FixedUpdate()
    {
        float delta = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) 
                                    || Input.GetKey(KeyCode.S) 
                                    || Input.GetKey(KeyCode.DownArrow))
            body.velocity = new Vector2(body.velocity.x, ChangeSpeed(delta));
        
    }
    
    private float ChangeSpeed(float delta)
    {
        speed = Mathf.Clamp(speed + delta, 0, maxSpeed);
        return speed;
    }
}
