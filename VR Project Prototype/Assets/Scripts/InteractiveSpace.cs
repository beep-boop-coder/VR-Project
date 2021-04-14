using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveSpace : MonoBehaviour
{

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
            SceneManageScript.ChangeToNextScene(1);
        }

        if (Input.GetKey(KeyCode.P))
        {
            SceneManageScript.ChangeToNextScene(1);
        }

    }
}
