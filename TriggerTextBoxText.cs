using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TriggerTextBoxText : MonoBehaviour
{
    // Start is called before the first frame update
    public Plant plant;
    public TextMeshProUGUI textDisplay;
    void Start()
    {
        // if(plant.isThirsty())
        // {
        //     textDisplay.text = "Water";
        // }
        // else
        // {
        //     textDisplay.text = "NOPE";
        // }
        // plant.GetTextScript();
        // plant.isThirsty();
        // textDisplay.text = "Water";
    }

    // Update is called once per frame
    void Update()
    {
        // if(plant.grow == plant.maxGrowth)
        // {
        //     textDisplay.text = "MaxGrowth!";
        // }
        if(plant.isThirsty())
        {
            if(plant.grow == plant.maxGrowth)
            {
                textDisplay.text = "Plant needs watering. MaxGrowth!";
            }
            else
            {
                textDisplay.text = "Plant needs watering";
            }
        }
        else
        {
            if(plant.grow == plant.maxGrowth)
            {
                textDisplay.text = "Plant is happy! MaxGrowth!";
            }
            else
            {
                textDisplay.text = "Plant is happy!";
            }
        }
    }
}
