using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lockSidebar : MonoBehaviour
{
    public Slider Menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void unlockMenu() //mades the menu/side bar interactable and can be moved around
    {
        Menu.interactable = true;
    }

    public void lockMenu() //mades the menu/side bar not interactable and cannot be moved around
    {
        Menu.interactable = false;
    }

}
