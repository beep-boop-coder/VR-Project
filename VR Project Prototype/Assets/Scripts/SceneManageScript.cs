using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{

    public static void ChangeToNextScene(int currentSceneIndex)
    {
        int maxSceneIndex = SceneManager.sceneCountInBuildSettings - 1;

        if (currentSceneIndex < maxSceneIndex)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
            Debug.Log("Loaded Next Scene, current scene = " + currentSceneIndex
                + "Max Scene = " + maxSceneIndex);
        }
        else
        {
            SceneManager.LoadScene(0);
            Debug.Log("Loaded Next Scene, current scene = " + currentSceneIndex
               + "Max Scene = " + maxSceneIndex);
        }
    }
}
