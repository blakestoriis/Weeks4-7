using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        clock.z -= speed; //sets rotation speed

        transform.eulerAngles = clock;

    }
}
