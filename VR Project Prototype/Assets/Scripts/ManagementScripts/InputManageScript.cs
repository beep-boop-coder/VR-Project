using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManageScript : MonoBehaviour
{

    public static bool CheckIfRayIntersectObject(GameObject OVRController)
    {
        GameObject InputController = OVRController;
        bool InteractableIntersected = true;

        RaycastHit hit;
        Ray ray = new Ray(InputController.transform.position, InputController.transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Interactable")
            {
                InteractableIntersected = true;
            }
        }
        else
        {
            InteractableIntersected = false;
        }

        return InteractableIntersected;
    }

    public static bool CheckIfTriggerPressed()
    {
        bool TriggerPressed = false;
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) | Input.GetKeyDown(KeyCode.T))
        {
            TriggerPressed = true;
        }
        else
        {
            TriggerPressed = false;
        }
        return TriggerPressed;
    }

    public static bool CheckIfTouchpadPressed()
    {
        bool TouchpadPressed = false;

        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad) | Input.GetKeyDown(KeyCode.P))
        {
            TouchpadPressed = true;
        }
        else
        {
            TouchpadPressed = false;
        }

        return TouchpadPressed;
    }
}
