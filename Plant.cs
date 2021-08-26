using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Plant : MonoBehaviour
{
    // public string Name;
    public DateTime watered;
    // public DateTime CurrentTime = DateTime.Now;
    public TriggerTextBoxText triggerTextBoxText;
    // public TextMeshProUGUI textDisplay;
    public bool EnrichedWater = false;

    public int grow = 0;
    public int maxGrowth = 5;

    public DateTime water()
    {
        if (isThirsty())
        {
            if(EnrichedWater)
            {
                watered = DateTime.Now;
                // Debug.Log("GROW+2");
                grow += 2;
                Debug.Log(grow);
                Debug.Log(watered.ToString("hh:mm:ss"));
                watered = watered.AddSeconds(10);
                EnrichedWater = false;
                return watered;
            }
            else
            {
                watered = DateTime.Now;
                // Debug.Log("GROW");
                grow++;
                Debug.Log(grow);
                Debug.Log(watered.ToString("hh:mm:ss"));
                watered = watered.AddSeconds(5);
                return watered;
            }
        }
        else
        {
            // Debug.Log("Plant is watered.");
            return watered;
        }
    }
    public bool isThirsty()
    {
        if(watered <= DateTime.Now)
        {
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
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        // Debug.Log("Plant is being watered");
        water();
        Debug.Log(watered.ToString("hh:mm:ss"));
    }
}
