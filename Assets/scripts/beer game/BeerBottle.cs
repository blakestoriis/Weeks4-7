using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Windows;

public class BeerBottle : MonoBehaviour
{

    public AnimationCurve BeerCurve; //animation of beer falling
    [Range(0, 1)]
    public float t = 0;//time



    public GameObject prefab; // beer bottle prefab

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //beer falls with animation curve when spawned
        t += Time.deltaTime * 0.25f; //updates time

        if (t > 1)
        {
            t = 0;
        }


        Vector3 beer = transform.position; // grab position
        beer.y -= BeerCurve.Evaluate(t); // set y position using the animation curve
        transform.position = beer;

        Destroy(gameObject, 5); //destroys itself after 5 seconds
    }

    public void spawnBeerBottle() //when the background is clicked on, a falling beer bottle will spawn
    {
        Vector3 beer;

        beer = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition); //sets a vector 3 variable to the mouse position
        beer.z = 0;
        transform.position = beer;
        
        

        Instantiate(prefab, beer, Quaternion.identity); //spawns at mouse position

    }

}
