using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public AimDirection shootDir;
    public void Click()
    {
        Debug.Log("you fired in direction " + shootDir.directionNum + " you probably hit a pedestrian!");
    }
}

//           this was to fix an issue i had earlier that ended up being fixed in some other way
//                                  yes i am just too lazy to remove it
//                                      yes it still has a job to do
