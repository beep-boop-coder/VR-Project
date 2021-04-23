using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPointer : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject interactable;
    [SerializeField] GameObject controller;

    int clickNum = 0;

    void Update()
    {
        if(InputManageScript.CheckIfRayIntersectObject(controller) == true)
        {
            if(InputManageScript.CheckIfTriggerPressed() == true)
            {
                clickNum += 1;

                if (clickNum % 2 == 0)
                {
                    text.SetActive(true);
                }
                else
                {
                    text.SetActive(false);
                }

            }
            else
            {

                interactable.GetComponent<MeshRenderer>().material.color = new Color(0.25f, 0.25f, 1);
            }

        }
        else
        {
            interactable.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1);
        }

    }
}
