using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backdropLerp : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;
    public Vector2 start;
    public Vector2 end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));
    }
}
