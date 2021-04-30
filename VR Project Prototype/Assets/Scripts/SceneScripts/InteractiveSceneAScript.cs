using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveSceneAScript : MonoBehaviour
{
    // script for the menu scene

    [SerializeField] GameObject text;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject effectButton;
    [SerializeField] GameObject leaveButton;
    [SerializeField] GameObject recycleButton;
    public static bool isTutorialDialogShown = false;

    [SerializeField] GameObject lController;
    [SerializeField] GameObject rController;
    GameObject controller;

    void Update()
    {
        if (StartSceneScript.isLeftController)
        {
            controller = lController;
            rController.SetActive(false);
        }
        else
        {
            controller = rController;
            lController.SetActive(false);
        }

        // stuff about dialog
        DialogManageScript.ChangeText(text, "在這裏，你可以點擊不同按鈕，得到更多有關垃圾對環境的傷害以及回收的資訊");

        if (Time.timeSinceLevelLoad > 5f)
        {
            DialogManageScript.ChangeText(text, "");
            panel.GetComponent<UnityEngine.UI.Image>().color -= new Color(0, 0, 0, 0.1f);
        }

        // Stuff about raycast and change to next scene
        RaycastHit hit;
        Ray ray = new Ray(controller.transform.position, controller.transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "Effect Button")
            {
                if (InputManageScript.CheckIfTriggerPressed() && Time.timeSinceLevelLoad > 1f)
                {
                    SceneManager.LoadScene("InteractiveSceneB");
                }

                effectButton.GetComponent<MeshRenderer>().material.color = new Color(0.75f, 0.75f, 1);
            }
            else
            {
                effectButton.GetComponent<MeshRenderer>().material.color = new Color(0.25f, 0.25f, 1);

            }
            if (hit.collider.gameObject.name == "Recycle Button")
            {
                if (InputManageScript.CheckIfTriggerPressed() && Time.timeSinceLevelLoad > 1f)
                {
                    SceneManager.LoadScene("InteractiveSceneB1");
                }

                recycleButton.GetComponent<MeshRenderer>().material.color = new Color(0.75f, 1, 0.75f);
            }
            else
            {
                recycleButton.GetComponent<MeshRenderer>().material.color = new Color(0.25f, 1, 0.25f);

            }

            // Script for exit options
            if (hit.collider.gameObject.name == "Leave Button")
            {
                if (InputManageScript.CheckIfTriggerPressed() && Time.timeSinceLevelLoad > 1f)
                {
                    SceneManager.LoadScene("FinalCutScene");
                }

                leaveButton.GetComponent<MeshRenderer>().material.color = new Color(1, 0.75f, 0.75f);
            }
            else
            {
                leaveButton.GetComponent<MeshRenderer>().material.color = new Color(1, 0.25f, 0.25f);

            }

        }

        
    }

}
