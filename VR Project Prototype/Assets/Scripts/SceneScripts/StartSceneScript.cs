using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject rController;
    [SerializeField] GameObject lController;

    public static bool isLeftController = false;


    void Update()
    {
        if (lController.transform.localPosition != new Vector3(0, 0, 0))
        {
            isLeftController = true;
        }
        else
        {
            isLeftController = false;
        }

        if (Time.timeSinceLevelLoad > 4f)
        {
            DialogManageScript.ChangeText(text, "現在按扳機便可開始方案");

            if(Time.timeSinceLevelLoad > 4.5f && InputManageScript.CheckIfTriggerPressed())
            {
                SceneManager.LoadScene("ChoiceScene");
            }
        } 

    }
}