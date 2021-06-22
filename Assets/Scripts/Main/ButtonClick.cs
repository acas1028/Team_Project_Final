using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.count >= 2)
        {
            GameManager.Instance.stageTip.gameObject.SetActive(true);
            GameManager.Instance.stageTip2.gameObject.SetActive(false);
        }
        else
        {
            GameManager.Instance.stageTip.gameObject.SetActive(false);
            GameManager.Instance.stageTip2.gameObject.SetActive(true);
        }
    }

    public void ReButtonClick()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main");
    }
    public void TitleButtonClick()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Title");
    }
    public void SettingButtonClick()
    {
        GameManager.Instance.Setting_Ui.gameObject.SetActive(true);
        GameManager.Instance.pause_Ui.gameObject.SetActive(false);
    }
    public void ExitSettingButtonClick()
    {
        GameManager.Instance.Setting_Ui.gameObject.SetActive(false); 
        GameManager.Instance.pause_Ui.gameObject.SetActive(true);
    }
}
