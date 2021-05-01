using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject text2;

    void Update()
    {
        if (Time.timeSinceLevelLoad > 4f)
        {
            text.GetComponent<Text>().text = "最後，你可以按一下扳機以重新開始方案";
            text2.GetComponent<Text>().text = "最後，你可以按一下扳機以重新開始方案";

            if (Time.timeSinceLevelLoad > 4.5f)
            {
                if (InputManageScript.CheckIfTriggerPressed())
                {
                    SceneManager.LoadScene("StartScene");
                }
                
            }
        }

    }
}