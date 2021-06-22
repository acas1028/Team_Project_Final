using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.time = 120.0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.time -= Time.deltaTime;

        if (GameManager.Instance.time < 0)
            GameManager.Instance.time = 0;


        this.gameObject.GetComponent<Text>().text = "LimitTime : " + Mathf.Round(GameManager.Instance.time);
    }
}
