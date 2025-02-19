using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class wigle : MonoBehaviour
{
    public AnimationCurve wiggle;
    [Range(0, 1)]
    public float t = 0;

    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        t += Time.deltaTime;

        if (mousePos.x < 1 && mousePos.x > -1 && mousePos.y < 1 && mousePos.y > -1) 
        {
            transform.localScale = Vector2.one * wiggle.Evaluate(t);
        }
    }
}
