using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapUi : MonoBehaviour
{
    Image uiColor;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 25; i++)
        {
            uiColor = gameObject.transform.GetChild(i).gameObject.GetComponent<Image>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 25; i++)
        {
            uiColor = gameObject.transform.GetChild(i).gameObject.GetComponent<Image>();
            if (GameManager.Instance.answerStage[i] == 0)
                uiColor.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
            else if (GameManager.Instance.answerStage[i] == 1)
                uiColor.color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
            else if (GameManager.Instance.answerStage[i] == 2)
                uiColor.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
            else
                uiColor.color = new Color(1.0f, 1.0f, 0.0f, 0.5f);
        }
    }
}
