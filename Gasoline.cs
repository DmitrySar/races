using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Gasoline : MonoBehaviour
{
    private Text gasoline;
    private float time = 0.333f;
    private float maxTime = 0.333f;
    private static int count = 100;

    void Start()
    {
        gasoline = GetComponent<Text>();
    }

    public static int Count
    {
        get => count;
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            count--;
            time = maxTime;
        }
        
        if (count < 0)
            GameController.StopGame();
        else if (count < 40 && count > 30)
            gasoline.color = Color.red;
        else if (count < 60 && count > 40)
            gasoline.color = Color.yellow;
        else if (count > 60)
            gasoline.color = Color.green;

        gasoline.text = "Топливо: " + count;
    }

    public static void Init()
    {
        count = 100;
    }

    public static void AddGasoline()
    {
        count = Mathf.Clamp(count + 50, 50, 100);
    }
}
