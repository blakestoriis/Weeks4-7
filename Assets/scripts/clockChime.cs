using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockChime : MonoBehaviour
{
    public AudioSource Chime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 clock = transform.eulerAngles;
        if (clock.z % 30 == 0)
        {
            if (!Chime.isPlaying)
            {
                GetComponent<AudioSource>().Play();
            }
        }

        transform.eulerAngles = clock;
    }
}
