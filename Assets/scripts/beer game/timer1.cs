using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timer1 : MonoBehaviour
{

    public float t; //timer value
    public Slider beerTimer; //created slidervariable/assigns slider

    public float score; //how many beers total
    public float beersPerSecond; //how many beers per second

    public float beersPerClick; // how many beers per player click

    //per second upgrade
    public float upgradeCost; //how much the next upgrade costs
    public float upgradeRate; //how many beers per second the upgrade gives

    //per click upgrade
    public float upgradeCost2; //how much the next upgrade costs
    public float upgradeRate2; //how many beers per second the upgrade gives

    //text display
    public TextMeshProUGUI scoreDisplay; //displays the score
    public TextMeshProUGUI beersPerSecondDisplay; //displays how many beers per second is being earned
    public TextMeshProUGUI beersPerClickDisplay; // how many beers per click
    public TextMeshProUGUI perSecondCostDisplay; //how many beers until next upgrade
    public TextMeshProUGUI perClickCostDisplay; //how many beers unil next upgrade

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

        //update score displays
        scoreDisplay.text = score.ToString();
        beersPerSecondDisplay.text = beersPerSecond.ToString();
        beersPerClickDisplay.text = beersPerClick.ToString();
        perSecondCostDisplay.text = upgradeCost.ToString();
        perClickCostDisplay.text = upgradeCost2.ToString();


    }

    public void upgrade() // when the upgrade button is clicked
    {

        if (score >= upgradeCost)
        {
            score -= upgradeCost; //subtracts cost from total score
            beersPerSecond += upgradeRate; //increases beers per second by the rate

            upgradeCost += upgradeCost; //cost doubles
            upgradeRate += upgradeRate; //rate doubles

            
        }

    }

    public void clicker()// increases score every click
    {
        score += beersPerClick;
    }


    public void upgradeClicker() // when the upgrade button is clicked
    {

        if (score >= upgradeCost2)
        {
            score -= upgradeCost2; //subtracts cost from total score
            beersPerClick += upgradeRate2; //increases beers per click by the rate

            upgradeCost2 += upgradeCost2; //cost doubles
            upgradeRate2 += upgradeRate2; //rate doubles


        }

    }

}
