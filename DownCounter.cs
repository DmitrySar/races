using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DownCounter : MonoBehaviour
{
    [SerializeField] Text downCounter;
    private int count = 3;
    void Start()
    {
        downCounter.text = "Нажмите пробел";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 4; i++)
                Invoke("ShowDownCounter", i);
        }
    }

    public void LoadLevel()
    {
        GameController.StartGame();
        SceneManager.LoadScene(1);
    }

    private void ShowDownCounter()
    {
        if (count == 0)
        {
            downCounter.text = "Старт";
            Invoke("LoadLevel", 1f);
        }
        else           
            downCounter.text = "" + count--;
    }

}
