using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponGlobal : MonoBehaviour
{
    public AimDirection aimDir;
    public static int range;
    public static int spread;
    public KeyControls keyControls;
    private InputAction Length;
    private InputAction Width;

    private void Awake()
    {
        keyControls = new KeyControls();
    }
    private void OnEnable()
    {
        Length = keyControls.Player.Fire;
        Length.Enable();
        Length.performed += Fire;
    }
    private void OnDisable()
    {
        Length.Disable();   
    }
    void Start()
    {
        range = 1;
        spread = 1;
        Debug.Log("range = " + range + " and spread = " + spread + ", North is direction " + aimDir.directionNum + " you bumbling bafoon");
    }

    // At this point its currently the same input for the two actions set to Q and E
    // Seperate them and then thats game
    private void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("fired");
    }
}


//                                                          Fornite Battle Pass