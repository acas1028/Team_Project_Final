using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUi : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        switch (GameManager.Instance.life)
        {
            case 0:
                if (gameObject.name == "heart2")
                    gameObject.SetActive(false);
                if (gameObject.name == "heart1")
                    gameObject.SetActive(false);
                if (gameObject.name == "heart0")
                    gameObject.SetActive(false);
                break;
            case 1:
                if (gameObject.name == "heart2")
                    gameObject.SetActive(false);
                if (gameObject.name == "heart1")
                    gameObject.SetActive(false);
                break;
            case 2:
                if (gameObject.name == "heart2")
                    gameObject.SetActive(false);
                break;
            case 3:
                break;
        }
    }
}
