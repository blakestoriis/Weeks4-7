using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class colour : MonoBehaviour
{
    public SpriteRenderer render;
    public Sprite sprite;

    public float rotateShape;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotateShape);
    }

    public void colourSquare()
    {
        render.color = Random.ColorHSV(); //random colour
    }

    public void rotate(float r)
    {
         rotateShape = r;
    }


}

