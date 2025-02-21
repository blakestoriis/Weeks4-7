using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class BeerBottle : MonoBehaviour
{

    public GameObject prefab; // beer bottle prefab

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
