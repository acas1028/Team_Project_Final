using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickScript : MonoBehaviour
{
    public GameObject OptionPanel;

    bool BGM, EF;

    // Start is called before the first frame update
    void Start()
    {
        BGM = false;
        EF = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Click
    public void StartButtonClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void OptionButtonClick()
    {
        OptionPanel.gameObject.SetActive(true);
    }

    public void BGMMuteButtonClick()
    {
        BGM = !BGM;
        Debug.Log("BGMMUTE " + BGM);
        if (BGM)
            GameObject.Find("BGM_Slider").GetComponent<Slider>().interactable = false;
        else
            GameObject.Find("BGM_Slider").GetComponent<Slider>().interactable = true;
    }

    public void EFMuteButtonClick()
    {
        EF = !EF;
        Debug.Log("EFMUTE " + EF);
        if (EF)
            GameObject.Find("EF_Slider").GetComponent<Slider>().interactable = false;
        else
            GameObject.Find("EF_Slider").GetComponent<Slider>().interactable = true;
    }

    public void ExitOptionButtonClick()
    {
        OptionPanel.gameObject.SetActive(false);
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }
}
