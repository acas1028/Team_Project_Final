using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundChange : MonoBehaviour
{
    public GameObject MusicSlider;
    public GameObject SoundSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SoundManager.Instance.AudioVol = SoundSlider.GetComponent<Slider>().value;
        SoundManager.Instance.MusicVol = MusicSlider.GetComponent<Slider>().value;
        this.GetComponent<AudioSource>().volume = SoundManager.Instance.MusicVol;
    }
}
