using UnityEngine;
using Random = UnityEngine.Random;

public class CarController : MonoBehaviour
{
    [SerializeField] private GameObject[] cars;
    private Rigidbody2D body;
    private GameObject car;
    private float limitX = 3.8f;
    private static float speed = 0f;
    private float maxSpeed = 28f;
    private GameObject track1;
    private GameObject track2;

    public static float Speed
    {
        get => speed;
    }

    void Start()
    {
        car = cars[Random.Range(0, 3)];
        car = Instantiate(car, transform.position, transform.rotation);
        transform.SetParent(car.transform);
        body = car.GetComponent<Rigidbody2D>();
        track1 = car.transform.Find("LeftTrack").gameObject;
        track2 = car.transform.Find("RightTrack").gameObject;
    }
    
    void Update()
    {
        float axisX = Input.GetAxis("Horizontal");
        float x = Mathf.Clamp(car.transform.position.x + axisX, -limitX, limitX);
        if (axisX != 0)
            car.transform.position = new Vector3(x,
                car.transform.position.y,
                car.transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, 0);
            ShowTrack();
            Invoke("HideTrack", 2f);
        }
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

    private void ShowTrack()
    {        
        track1.SetActive(true);
        track2.SetActive(true);
    }

    private void HideTrack()
    {
        track1.SetActive(false);
        track2.SetActive(false);
    }
        
}
