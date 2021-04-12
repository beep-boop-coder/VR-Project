using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{

    public static void ChangeToNextScene()
    {
        int maxSceneIndex = SceneManager.sceneCount - 1;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex < maxSceneIndex)
        {
            SceneManager.LoadSceneAsync(currentSceneIndex + 1);
            Debug.Log("Loaded Next Scene, current scene =" + currentSceneIndex);
        }
        else
        {
            SceneManager.LoadSceneAsync(0);
            Debug.Log("Loaded First Scene, current scene =" + currentSceneIndex);
        }
    }
}
