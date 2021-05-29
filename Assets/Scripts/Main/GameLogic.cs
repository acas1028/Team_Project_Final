using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.count = 3;
        GameManager.Instance.life = 3;
        GameManager.Instance.SetAnswer();
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.CheckLight();

        if (GameManager.Instance.count <= 1)
            GameManager.Instance.LastMission();

        if (GameManager.Instance.life <= 0)
            SceneManager.LoadScene("Fail");

        if (GameManager.Instance.destroyCount >= 24)
        {
            GameManager.Instance.count = 0;
            SceneManager.LoadScene("Clear");
        }
    }
}
