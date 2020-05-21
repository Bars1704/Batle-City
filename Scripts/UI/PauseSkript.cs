
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class PauseSkript : MonoBehaviour
{
    bool isPause = false;
    public KeyCode PauseKey = KeyCode.Escape;
    public GameObject menupanel;
    public TimerScript ts;
    public void ChangePauseStatus(bool pause)
    {
        isPause = pause;
        menupanel.SetActive(isPause);
        if (isPause)
        {
            
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void GoToMainMenu()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "SampleScene")
        {
            Session ses = new Session(ts.time);
            ses.Add();
        }
        if (ArbitrScript.Tank1 != null)
            Destroy(ArbitrScript.Tank1.gameObject);
        if (ArbitrScript.Tank2 != null)
            Destroy(ArbitrScript.Tank2.gameObject);
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);

    }

    void Update()
    {
        if (Input.GetKeyDown(PauseKey) && !isPause)
        {
            ChangePauseStatus(true);
        }
    }
    private void Start()
    {
        menupanel.SetActive(false);
    }
}
