using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DownCounter : MonoBehaviour
{
    private Text downCount;
    private int count = 3;
    void Start()
    {
        downCount = GetComponent<Text>();
        downCount.text = "Нажмите пробел";
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            for (int i = 0; i < 4; i++)
                Invoke("ShowCount", i);
                
    }

    private void ShowCount()
    {
        if (count == 0)
        {
            downCount.text = "Старт";
            Invoke("LoadLevel", 1f);
        }
        else
            downCount.text = "" + count--;
    }

    private void LoadLevel()
    {
        GameController.StartGame();
    }
}
