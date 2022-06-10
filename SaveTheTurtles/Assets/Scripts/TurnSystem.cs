using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// All the states that the game can be in
public enum TurnState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class TurnSystem : MonoBehaviour
{
    public TurnState state;

    private void Start()
    {
        state = TurnState.START;
    }

    private void Update()
    {
        if (state == TurnState.LOST)
        {
            Debug.Log("Get Nae Naed");
            state = TurnState.START;
        }
    }
}
