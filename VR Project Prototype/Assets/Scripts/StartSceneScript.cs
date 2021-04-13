using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            SceneManageScript.ChangeToNextScene(0);
        }

        if (Input.GetKey(KeyCode.T))
        {
            SceneManageScript.ChangeToNextScene(0);
        }


    }
}