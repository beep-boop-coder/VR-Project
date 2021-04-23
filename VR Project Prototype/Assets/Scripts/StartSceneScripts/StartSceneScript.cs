using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneScript : MonoBehaviour
{

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)| Input.GetKey(KeyCode.T))
        {
            SceneManageScript.ChangeToNextScene(0);
        }

    }
}