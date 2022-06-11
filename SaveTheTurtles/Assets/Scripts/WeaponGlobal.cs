using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponGlobal : MonoBehaviour
{
    public int directionNum;
    private void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }
    public void Click()
    {
        Debug.Log("you fired in direction " + directionNum + " for " + StatHandler.range + " units far and " + StatHandler.spread + " units wide!" + "You probably hit a pedestrian!");
        StatHandler.range = 1;
        StatHandler.spread = 1;
        Debug.Log("End Turn Here");

    }

}


//                                                          Fornite Battle Pass