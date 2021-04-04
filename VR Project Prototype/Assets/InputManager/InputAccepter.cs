using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAccepter : MonoBehaviour
{
    private void Awake(){
        PlayerInput.onTriggerDown += TriggerDown;
        PlayerInput.onTriggerUp += TriggerUp;
    }
    private void TriggerDown(){
        print("Trigger down");
    }

    private void TriggerUp(){
        print("Trigger up");
    }
}
