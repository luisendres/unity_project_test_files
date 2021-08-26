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
        if(plant.isThirsty())
        {
            textDisplay.text = "Plant needs watering";
        }
        else
        {
            textDisplay.text = "Plant is happy!";
        }
    }
}
