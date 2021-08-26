using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Plant : MonoBehaviour
{
    // public string Name;
    public DateTime watered;
    // public bool Thirsty;
    // public DateTime CurrentTime = DateTime.Now;

    public TriggerTextBoxText triggerTextBoxText;
    // public TextMeshProUGUI textDisplay;

    public void GetTextScript()
    {
        Debug.Log("Plant method called");
    }

    public DateTime water()
    {
        // Debug.Log("Test");
        if (isThirsty())
        {
            watered = DateTime.Now;
            // double hour = 12;
            // return watered.AddHours(hour);
            // watered.AddSeconds(30);
            Debug.Log("WATERING");
            Debug.Log(watered.ToString("hh:mm:ss"));
            watered = watered.AddSeconds(5);
            return watered;
        }
        else
        {
            // return Debug.Log("Plant is watered.");
            // Debug.Log("Plant is watered.");
            return watered;
        }
    }
    public bool isThirsty()
    {
        if(watered <= DateTime.Now)
        {
            // textDisplay.text = "Water";
            // triggerTextBoxText.textDisplay.text = "Water";
            // Debug.Log("Plant needs to be watered!");
            return true;
        }
        // else if(watered == null)
        // {
        //     return true;
        // }
        // Debug.Log("STOP! Plant is watered.");
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        isThirsty();
        // DateTime now = DateTime.Now;
        // now.ToString("hh:mm");
        // Debug.Log(now);
        // Debug.Log(now.ToString("hh:mm"));
        // Debug.Log("Test");
        // if (isThirsty())
        // {
        //     // place holder for other functions
        //     Debug.Log("Plant needs to be watered!");
        //     // textDisplay.text = "Testing";
        //     // return true;
        // }
        // else
        // {
        //     // place holder for other functions
        //     Debug.Log("STOP! Plant is watered.");
        //     // return false;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
        // if(watered <= DateTime.Now)
        // {
        //     Debug.Log("needs to be watered!");
        //     isThirsty = false;
        // } 
        // else 
        // {
        //     Debug.Log("Plant is watered.");
        //     isThirsty = true;
        // }


        // if (isThirsty())
        // {
        //     // place holder for other functions
        //     Debug.Log("needs to be watered!");
        //     // return true;
        // }
        // else
        // {
        //     // place holder for other functions
        //     Debug.Log("Plant is watered.");
        //     // return false;
        // }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // Debug.Log("Plant is being watered");
        water();
        Debug.Log(watered.ToString("hh:mm:ss"));
    }
}
