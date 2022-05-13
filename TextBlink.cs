using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextBlink : MonoBehaviour
{
    private Text gasoline;
    private void Start()
    {
        gasoline = GetComponent<Text>();
        StartCoroutine("Blink");
    }

    private IEnumerator Blink()
    {
        while (true)
        {
            if (Gasoline.Count <= 30)
            {
                gasoline.color = Color.black;
                yield return new WaitForSeconds(0.5f);
                gasoline.color = Color.red;
                yield return new WaitForSeconds(0.5f);
            }
            else
                yield return new WaitForSeconds(1f);
        }
    }

}
