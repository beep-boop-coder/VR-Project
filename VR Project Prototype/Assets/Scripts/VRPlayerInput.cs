using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRPlayerInput : MonoBehaviour
{


    void Update()
    { 

        // Trigger pressed
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            SceneManager.LoadScene("360VideoTest");
        }
    }
}
