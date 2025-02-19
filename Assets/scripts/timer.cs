using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public Slider time;
    public float length;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        time.maxValue = audioSource.clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSource != null && audioSource.isPlaying)
        {
            AudioTimer(audioSource.time);
        }


    }

    public void AudioTimer(float t)
    {
        time.value = t;
    }
}
