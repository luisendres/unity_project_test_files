using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisable : MonoBehaviour
{
    public GameObject button1;
    public Plant plant;

    // Update is called once per frame
    void Update()
    {
        if(!plant.isThirsty())
        {
            button1.SetActive (false);
        }
        else 
        {
            button1.SetActive (true);
        }
    }
}
