using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static void StopGame()
    {
        SceneManager.LoadScene(0);
    }

    public static void StartGame()
    {
        Score.recordTime = new System.DateTime();
        Gasoline.AddGasoline();
        Gasoline.AddGasoline();
    }
}
