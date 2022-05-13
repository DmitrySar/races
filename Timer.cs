using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timer;
    void Start()
    {
        timer = GetComponent<Text>();
    }

    void Update()
    {
        Score.timeScore = new DateTime().AddSeconds((int)Time.timeSinceLevelLoad);
        timer.text = Score.timeScore.Minute.ToString("00") + ":"
            + Score.timeScore.Second.ToString("00");
    }
}
