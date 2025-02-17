using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource chime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 clock = transform.eulerAngles; 
        if (clock.z == clock.z % 30)
        {
            if (!chime.isPlaying)
            {
                chime.Play();
            }
        }
        transform.eulerAngles = clock;
    }
}
