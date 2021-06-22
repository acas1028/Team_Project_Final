using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;


    public float MusicVol;
    public float AudioVol;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            if (Instance != this)
                Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        MusicVol = 0.5f;
        AudioVol = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
  
    }


}
