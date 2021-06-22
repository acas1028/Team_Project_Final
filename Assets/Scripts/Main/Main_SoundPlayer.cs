using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_SoundPlayer : MonoBehaviour
{
    public AudioClip[] sound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(int num)
    {
        this.GetComponent<AudioSource>().clip = sound[num];
        this.GetComponent<AudioSource>().Play();
    }

}
