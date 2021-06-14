using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Slider>().value = SoundManager.Instance.AudioVol;
    }

    // Update is called once per frame
    void Update()
    {
        SoundManager.Instance.AudioVol = this.gameObject.GetComponent<Slider>().value;
    }
}
