using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterButtons : MonoBehaviour
{
    public Plant plant;
    public void EnrichedPanelDialogOk()
        {
            plant.EnrichedWater = true;
        }
}
