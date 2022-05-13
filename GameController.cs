using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static float limitX = 3.8f;
    public static float LimitX => limitX;

    public static void StartGame()
    {
        Score.timeScore = new DateTime();
        Gasoline.Init();
        SceneManager.LoadScene(1);
    }

    public static void StopGame()
    {
        SceneManager.LoadScene(0);
    }
}
