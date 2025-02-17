using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class mouseHover : MonoBehaviour
{

    public AnimationCurve chicken;
    [Range(0, 1)]
    public float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            t += Time.deltaTime;
        }

        if (t > 1)
        {
            t = 0;
        }

        transform.localScale = Vector2.one * chicken.Evaluate(t);

    }
}
