using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_SoundChange2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<AudioSource>().volume = SoundManager.Instance.AudioVol;
    }
}
