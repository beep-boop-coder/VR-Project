using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlumScript : MonoBehaviour
{
 
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "TrashDetector" |
           collision.gameObject.name == "PaperDetector" |
           collision.gameObject.name == "PlasticDetector")
        {
            ChoiceSceneScript.playerThrowNum += 1;
            Debug.Log(ChoiceSceneScript.playerThrowNum);
            gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "AlumDetector")
        {
            ChoiceSceneScript.playerCorrectNum += 1;
            ChoiceSceneScript.playerThrowNum += 1;
            Debug.Log(ChoiceSceneScript.playerThrowNum);
            gameObject.SetActive(false);
        }

        
    }
}
