using UnityEngine;
using UnityEngine.UI;

public class LastTime : MonoBehaviour
{
    private Text timer;
    void Start()
    {
        timer = GetComponent<Text>();
        timer.text = Score.timeScore.Minute.ToString("00") + ":"
            + Score.timeScore.Second.ToString("00");
    }

}
