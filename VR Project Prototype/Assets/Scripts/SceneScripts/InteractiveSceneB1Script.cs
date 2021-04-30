using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveSceneB1Script : MonoBehaviour
{
    //script for the land option

    [SerializeField] GameObject text;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject informationA;
    bool displayInformationA;

    [SerializeField] GameObject informationB;
    bool displayInformationB;

    [SerializeField] GameObject informationC;
    bool displayInformationC;

    [SerializeField] GameObject lReticule;
    [SerializeField] GameObject rReticule;
    GameObject reticule;

    [SerializeField] GameObject lController;
    [SerializeField] GameObject rController;
    GameObject controller;

    private void Start()
    {
        displayInformationA = false;
        displayInformationB = false;
        displayInformationC = false;
    }

    void FixedUpdate()
    {
        if (StartSceneScript.isLeftController)
        {
            controller = lController;
            reticule = lReticule;
            rController.SetActive(false);
        }
        else
        {
            controller = rController;
            reticule = rReticule;
            lController.SetActive(false);
        }

        RaycastHit hit;
        Ray ray = new Ray(controller.transform.position, controller.transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            reticule.transform.localPosition = new Vector3(reticule.transform.localPosition.x, reticule.transform.localPosition.y, hit.distance);

            if(hit.collider.gameObject.name == "GarbageHeap")
            {
                if (InputManageScript.CheckIfTriggerPressed())
                {
                    if (displayInformationA)
                    {
                        displayInformationA = false;
                    }
                    else
                    {
                        displayInformationA = true;
                    }
                    
                }   
            }

            if(hit.collider.gameObject.name == "Cola Can")
            {
                if (InputManageScript.CheckIfTriggerPressed())
                {
                    if (displayInformationB)
                    {
                        displayInformationB = false;
                    }
                    else
                    {
                        displayInformationB = true;
                    }
                    
                }   
            }

            if (hit.collider.gameObject.name == "WaterBottle")
            {
                if (InputManageScript.CheckIfTriggerPressed())
                {
                    if (displayInformationC)
                    {
                        displayInformationC = false;
                    }
                    else
                    {
                        displayInformationC = true;
                    }

                }
            }

        }

        if (displayInformationA)
        {
            informationA.SetActive(true);
        }
        else
        {
            informationA.SetActive(false);
        }

        if (displayInformationB)
        {
            informationB.SetActive(true);
        }
        else
        {
            informationB.SetActive(false);
        }

        if (displayInformationC)
        {
            informationC.SetActive(true);
        }
        else
        {
            informationC.SetActive(false);
        }

        if (!InteractiveSceneAScript.isTutorialDialogShown)
        {
            DialogManageScript.ChangeText(text, "用扳機按任何在地上的物體，以了解它們對環境造成的傷害");

            if (Time.timeSinceLevelLoad > 5f)
            {
                DialogManageScript.ChangeText(text, "記得你隨時都可以按下遙控器觸控板以離開場面");
                
            }

        }
        else
        {
            panel.GetComponent<UnityEngine.UI.Image>().color -= new Color(0, 0, 0, 0.1f);

        }

        if (Time.timeSinceLevelLoad > 7f)
        {
            DialogManageScript.ChangeText(text, "");

            InteractiveSceneAScript.isTutorialDialogShown = true;

            panel.GetComponent<UnityEngine.UI.Image>().color -= new Color(0, 0, 0, 0.1f);
        }

        if (InputManageScript.CheckIfTouchpadPressed())
        {
            SceneManager.LoadScene("InteractiveSceneA");
        }
        
    }
}
