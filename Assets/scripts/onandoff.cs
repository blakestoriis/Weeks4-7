using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onandoff : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    //public EnableDisable script;
    public AudioSource Audios;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
            go.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = false;
            go.SetActive(false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if(!Audios.isPlaying)
            {
                //Audios.Play();
                Audios.PlayOneShot(clip);
            }
            //Audios.clip.length
        }
    }
}
