using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform car;
    [SerializeField] private Transform road1;
    [SerializeField] private Transform road2;
    private float roadDistance;
    private float cameraDistance;
    void Start()
    {
        cameraDistance = transform.position.y - car.position.y;
        roadDistance = road2.position.y - road1.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            car.position.y + cameraDistance,
            transform.position.z);

        float y = transform.position.y;
        if (y > road1.position.y + roadDistance)
            MoveRoad(road1);
        if (y > road2.position.y + roadDistance)
            MoveRoad(road2);
    }
    
    private void MoveRoad(Transform t)
    {
        t.position = new Vector3(t.position.x,
            t.position.y + 2 * roadDistance,
            t.position.z);
    }
}
