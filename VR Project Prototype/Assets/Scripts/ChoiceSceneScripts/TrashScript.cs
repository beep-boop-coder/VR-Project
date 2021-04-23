using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "TrashDetector")
        {
            SceneManager.LoadSceneAsync("TrashChoiceScene");
        }

        if (collision.gameObject.name == "RecyclingDetector")
        {
            SceneManager.LoadSceneAsync("RecyclingChoiceScene");
        }
    }
}
