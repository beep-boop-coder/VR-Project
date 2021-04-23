using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGunScript : MonoBehaviour
{

    // The code below allow player to pick up object with trigger
    [SerializeField] float maxGrabDistance = 10f, lerpSpeed = 10f;
    [SerializeField] Transform objectHolder;
    [SerializeField] GameObject Controller;
    [SerializeField] GameObject reticule;

    Rigidbody grabbedRB;

    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = new Ray(Controller.transform.position, Controller.transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            reticule.transform.localPosition = new Vector3(reticule.transform.localPosition.x, reticule.transform.localPosition.y, hit.distance);
        }
        
        if (grabbedRB)
        {
            grabbedRB.MovePosition(Vector3.Lerp(grabbedRB.position, objectHolder.transform.position, Time.deltaTime * lerpSpeed));
        
        }

        if (InputManageScript.CheckIfTriggerPressed())
        {
            if (grabbedRB)
            {
                grabbedRB.isKinematic = false;
                grabbedRB = null;
            }
            else
            {
                RaycastHit pressedHit;
                Ray pressedRay = new Ray(Controller.transform.position, Controller.transform.forward);

                if (Physics.Raycast(pressedRay, out pressedHit, maxGrabDistance))
                {
                    grabbedRB = pressedHit.collider.gameObject.GetComponent<Rigidbody>();
                    if (grabbedRB)
                    {
                        grabbedRB.isKinematic = true;
                    }
                }

            }
        }
    }
}

