using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    public Text resultText;

    public float now;
    public float best;

    // Start is called before the first frame update
    void Start()
    {
        now = GameManager.Instance.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerPrefs.HasKey("bestscore"))
        {
            PlayerPrefs.SetFloat("bestscore", now);
            PlayerPrefs.Save();
        }

        best = PlayerPrefs.GetFloat("bestscore");

        if (now > best)
            best = now;

        PlayerPrefs.SetFloat("bestscore", best);
        PlayerPrefs.Save();

        resultText.text = "BestClearTime: " + best + "\n Press Space Bar";
    }
}
