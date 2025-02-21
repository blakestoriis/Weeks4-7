using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer1 : MonoBehaviour
{

    public float t; //timer value
    public Slider beerTimer; //created slidervariable/assigns slider

    public float score; //how many beers total
    public float beersPerSecond; //how many beers per second

    public float beersPerClick; // how many beers per player click

    public float upgradeCost; //how much the next upgrade costs
    public float upgradeRate; //how many beers per second the upgrade gives

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime; // sets time
        beerTimer.value = t % beerTimer.maxValue; // sets slider to max value

        if (t >= beerTimer.maxValue) // every 1 second score increases
        {
            score += beersPerSecond; //adds beers per second to the score
            t = 0f; // resets the timer
        }
    }

    public void upgrade() // when the upgrade button is clicked
    {

        if (score >= upgradeCost)
        {
            score -= upgradeCost; //subtracts cost from total score
            beersPerSecond += upgradeRate; //increases beers per second by the rate

            upgradeCost += upgradeCost; //cost doubles
            upgradeRate += upgradeRate * 0.5f; //rate increases by 0.5

            
        }
    }

}
