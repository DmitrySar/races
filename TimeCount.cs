using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    [SerializeField] private Text time;

    void Update()
    {
        Score.recordTime = new DateTime().AddSeconds(Time.timeSinceLevelLoad);
        time.text = Score.recordTime.Minute + ":" +
            Score.recordTime.Second.ToString("00");
    }
}
