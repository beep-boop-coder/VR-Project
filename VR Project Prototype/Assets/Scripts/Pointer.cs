using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public GameObject Text;
    public GameObject Interactable;
    public GameObject Controller;

    int clickNum = 0;

    void Update()
    {
        RaycastHit hit;
        Ray pointerRay = new Ray(Controller.transform.position, Controller.transform.forward);

        if (Physics.Raycast(pointerRay, out hit))
        {
            if (hit.collider.tag == "Interactable")
            {
                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) |
                    Input.GetKey(KeyCode.T))
                {
                    clickNum += 1;

                    if (clickNum%2 == 0)
                    {
                        Text.SetActive(true);
                    }
                    else
                    {
                        Text.SetActive(false);
                    }
                    
                }

                Interactable.GetComponent<MeshRenderer>().material.color = new Color(0.25f, 0.25f, 1);
            }
        }
        else
        {
            Interactable.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1);
        }

    }
}
