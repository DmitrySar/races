using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    private Text score;
    void Start()
    {
        score = GetComponent<Text>();
        score.text = "Время заезда: " + Score.recordTime.Minute + ":" +
            Score.recordTime.Second.ToString("00");
    }

}
