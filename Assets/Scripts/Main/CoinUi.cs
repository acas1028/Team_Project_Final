using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinUi : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        switch (GameManager.Instance.count)
        {
            case 0:
                if (gameObject.name == "coin0")
                    gameObject.SetActive(false);
                if (gameObject.name == "coin1")
                    gameObject.SetActive(false);
                if (gameObject.name == "coin2")
                    gameObject.SetActive(false);
                break;
            case 1:
                if (gameObject.name == "coin1")
                    gameObject.SetActive(false);
                if (gameObject.name == "coin2")
                    gameObject.SetActive(false);
                break;
            case 2:
                if (gameObject.name == "coin2")
                    gameObject.SetActive(false);
                break;
            case 3:
                break;
        }
    }
}
