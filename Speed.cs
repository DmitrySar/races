using System;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    [SerializeField] private Text speed;

    void Start()
    {
        
    }

    void Update()
    {
        speed.text = "Скорость: " + (int) CarController.Speed * 5f;
       
    }
}
