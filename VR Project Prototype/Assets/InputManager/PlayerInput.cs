using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public static UnityAction<bool> onHasController = null;

    private bool hasController = false;
    private bool inputActive = true;

    public static UnityAction onTriggerUp = null;
    public static UnityAction onTriggerDown = null;
    public static UnityAction onTouchpadUp = null;
    public static UnityAction onTouchpadDown = null;

    private void Awake(){
        OVRManager.HMDMounted += PlayerFound;
        OVRManager.HMDUnmounted += PlayerLost;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDestroy(){
        OVRManager.HMDMounted -= PlayerFound;
        OVRManager.HMDUnmounted -= PlayerLost;
    }

    // Update is called once per frame
    void Update()
    {
        if(!inputActive)
            return;

            hasController = CheckForController(hasController);

        //This event will fire once the trigger is pushed down
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)){
            if(onTriggerDown != null){
                onTriggerDown();
            }
        }
        //This event will fire once the trigger is not pushed down
        if(OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger)){
            if(onTriggerUp != null){
                onTriggerUp();
            }
        }
        //This event will fire once the touchpad is pushed down
        if(OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad)){
            if(onTriggerDown != null){
                onTouchpadDown();
            }
        }
        //This event will fire once the touchpad is not pushed down
        if(OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad)){
            if(onTriggerUp != null){
                onTriggerUp();
            }
        }

        float triggerValue = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);

        if(triggerValue > 0.5f){
            //do stuff in here
        }
        
    }

    private bool CheckForController(bool currentValue){
        bool controllerCheck = OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote);

        if(currentValue == controllerCheck)
            return currentValue;

        if(onHasController != null)
            onHasController(controllerCheck);


        return controllerCheck;
    }

    private void PlayerFound(){
        inputActive = true;
    }

    private void PlayerLost(){
        inputActive = false;
    }
}
