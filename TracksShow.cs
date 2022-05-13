using UnityEngine;

public class TracksShow : MonoBehaviour
{
    private GameObject car;
    private GameObject leftTrack;
    private GameObject rightTrack;
    private float showTimeTrack = 1f;
    private float currentTime = 1f;
    void Start()
    {
        car = CarController.Car;
        leftTrack = car.transform.Find("LeftTrack").gameObject;
        rightTrack = car.transform.Find("RightTrack").gameObject;
    }
    
    void Update()
    {
        if (Input.GetKey("down"))
        {
            currentTime -= Time.deltaTime;
            if (currentTime < 0)
            {
                ShowTracks();
                Invoke("HideTracks", showTimeTrack);
            }
        }

        if (Input.GetKeyUp("down"))
            currentTime = showTimeTrack;
    }

    private void ShowTracks()
    {
        leftTrack.SetActive(true);
        rightTrack.SetActive(true);
    }

    private void HideTracks()
    {
        leftTrack.SetActive(false);
        rightTrack.SetActive(false);
    }
}
