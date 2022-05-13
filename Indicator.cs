using UnityEngine;
using UnityEngine.UI;

public class Indicator : MonoBehaviour
{
    [SerializeField] private Text speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed.text = "Скорость: " + (int) CarController.Speed * 5f;
    }
}
