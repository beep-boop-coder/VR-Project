using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlasticScript : MonoBehaviour
{
 
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "TrashDetector" |
           collision.gameObject.name == "PaperDetector" |
           collision.gameObject.name == "AlumDetector")
        {
            ChoiceSceneScript.playerThrowNum += 1;
        }
        else if (collision.gameObject.name == "PlasticDetector")
        {
            ChoiceSceneScript.playerCorrectNum += 1;
            ChoiceSceneScript.playerThrowNum += 1;
        }

    }
}
