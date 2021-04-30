using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceSceneScript : MonoBehaviour
{
    public static int playerCorrectNum;
    public static int playerThrowNum;

    // The code below allow player to pick up object with trigger
    [SerializeField] float maxGrabDistance = 10f, lerpSpeed = 10f; 
    [SerializeField] GameObject text;

    [SerializeField] Transform lObjectHolder;
    [SerializeField] Transform rObjectHolder;
    Transform objectHolder;

    [SerializeField] GameObject lReticule;
    [SerializeField] GameObject rReticule;
    GameObject reticule;

    [SerializeField] GameObject lController;
    [SerializeField] GameObject rController;
    GameObject controller;

    Rigidbody grabbedRB;

    void FixedUpdate()
    {
           
        if (StartSceneScript.isLeftController)
        {
            objectHolder = lObjectHolder;
            controller = lController;
            reticule = lReticule;
            rController.SetActive(false);
        }
        else
        {
            objectHolder = rObjectHolder;
            controller = rController;
            reticule = rReticule;
            lController.SetActive(false);
        }
            

        RaycastHit hit;
        Ray ray = new Ray(controller.transform.position, controller.transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            reticule.transform.localPosition = new Vector3(reticule.transform.localPosition.x, reticule.transform.localPosition.y, hit.distance);
        }
        
        if (grabbedRB)
        {
            if(SceneManager.GetActiveScene().name == "ChoiceScene")
            {
                DialogManageScript.ChangeText(text, "現在你可以把這些垃圾放在你覺得適合的垃圾桶");
            }
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
                Ray pressedRay = new Ray(controller.transform.position, controller.transform.forward);

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

        // Change to next scene script
        if (playerThrowNum == 2)
        {
            if (playerCorrectNum >= playerThrowNum)
            {
                SceneManager.LoadSceneAsync("RecycleSceneA");
            }
            else
            {
                SceneManager.LoadSceneAsync("TrashSceneA");
            }
        }
        
    }
}

