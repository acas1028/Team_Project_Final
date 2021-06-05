using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }
    //==============================


    public int count;
    public int life;
    public int destroyCount;
    public int[] answerStage = new int[25];
    public int[] checkStage = new int[25];

    public bool interactCheck;
    public bool pause;

    public GameObject stageUi;
    public GameObject puaseUi;
    public GameObject stageAnswer;
    public GameObject stageLast;
    public GameObject stageTip;
    public GameObject stageTip2;

    public void SetAnswer()
    {
        for (int i = 0; i < 25; i++)
        {
            int temp = Random.Range(0, 2);

            if (temp == 0)
                GameManager.Instance.answerStage[i] = 1;
            else if (temp == 1)
                GameManager.Instance.answerStage[i] = 2;

            if (GameManager.Instance.count >= 2)
                GameManager.Instance.answerStage[0] = 3;
        }
    }
    public bool CheckAnswer()
    {
        int tempCount = 0;
        for (int i = 0; i < 25; i++)
        {
            if (checkStage[i] == answerStage[i])
                tempCount++;

            if (tempCount >= 24)
                return true;
        }
        return false;
    }
    public void CheckLight()
    {
        GameObject lightObject = null;
        for (int i = 0; i < 25; i++)
        {
            lightObject = GameObject.Find("Map/FieldObjects/CircleObjects").transform.GetChild(i).gameObject;

            if (lightObject.GetComponent<CircleObject>().GetIsLighting() == 1)
                GameManager.Instance.checkStage[i] = 1;
            else if (lightObject.GetComponent<CircleObject>().GetIsLighting() == 2)
                GameManager.Instance.checkStage[i] = 2;
        }
    }
    public void LastMission()
    {
        GameManager.Instance.stageAnswer.gameObject.SetActive(false);
        GameManager.Instance.stageLast.gameObject.SetActive(true);
    }


    //==============================
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        //DontDestroyOnLoad(gameObject);
    }
}
