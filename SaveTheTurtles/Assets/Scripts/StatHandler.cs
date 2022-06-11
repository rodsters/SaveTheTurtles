using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StatHandler : MonoBehaviour
{
    // Q = Range and E = Spread


    public KeyControls keyCon;
    private InputAction Length;
    private InputAction Width;
    public static int range;
    public static int spread;
    public void Awake()
    {
        keyCon = new KeyControls();
        range = 1;
        spread = 1;
        Debug.Log("range = " + range + " and spread = " + spread + " you bumbling bafoon");
    }
    public void OnEnable()
    {
        Length = keyCon.Keybinds.RangeIncrease;
        Width = keyCon.Keybinds.SpreadIncrease;
        Width.Enable();
        Length.Enable();
        Length.performed += Range;
        Width.performed += Spread;
    }
    public void OnDisable()
    {
        Length.Disable();
    }
    public void Range(InputAction.CallbackContext context)
    {

        range = range + 1;
        Debug.Log("Range:" + range + " End Turn Here");
    }
    public void Spread(InputAction.CallbackContext context)
    {
        spread = spread + 1;
        Debug.Log("Spread:" + spread + " End Turn Here");
    }

}
//           i am in Missouri
