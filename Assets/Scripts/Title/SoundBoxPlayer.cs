using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundBoxPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        this.GetComponent<AudioSource>().Play();
    }

    public void PlaySoundAndDestroy()
    {
        this.GetComponent<AudioSource>().Play();
        Destroy(gameObject, 2.0f);
    }
}
