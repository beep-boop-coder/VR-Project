using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneScript : MonoBehaviour
{
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) | Input.GetKey(KeyCode.T))
        {
            SceneManageScript.ChangeToNextScene(2);
        }

    }
}