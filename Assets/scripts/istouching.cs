using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istouching : MonoBehaviour
{
    public GameObject player;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.x < 2 && player.transform.position.x > -2 && player.transform.position.y < 2 && player.transform.position.y > -2)
        {
            text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
        }
    }
}
