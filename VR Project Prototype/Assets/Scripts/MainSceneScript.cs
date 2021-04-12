using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneScript : MonoBehaviour
{
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            SceneManageScript.ChangeToNextScene();
        }

        if (Input.GetKey(KeyCode.T))
        {
            SceneManageScript.ChangeToNextScene();
        }


    }
}