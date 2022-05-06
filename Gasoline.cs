using UnityEngine;
using UnityEngine.UI;

public class Gasoline : MonoBehaviour
{
    [SerializeField] private Text gasoline;
    private static float count = 100;

    void Update()
    {
        count -= Time.deltaTime * 3;
        if (count < 0)
            GameController.StopGame();
        else if (count < 40)
            gasoline.color = Color.red;
        else if (count < 60)
            gasoline.color = Color.yellow;
        else
            gasoline.color = Color.green;

        gasoline.text = "Топливо: " + count.ToString("0"); 
    }

    public static void AddGasoline()
    {
        count = Mathf.Clamp(count + 50, 50, 100);
    }
}
