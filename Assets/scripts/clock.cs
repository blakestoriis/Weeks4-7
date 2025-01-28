using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 clock = transform.eulerAngles;
        clock.z -= speed;

        if (clock.z == 180)
        {

        }
        transform.eulerAngles = clock;

    }
}
