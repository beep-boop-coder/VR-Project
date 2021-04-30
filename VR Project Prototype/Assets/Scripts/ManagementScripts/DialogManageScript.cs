using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManageScript : MonoBehaviour
{
    static bool willFade = true;

    public static void ChangeText(GameObject targetObject, string newText)
    {
        float fadeValue;
        
        if (targetObject.GetComponent<Text>().color.a < 0f)
        {
            willFade = false;
        }

        if (willFade == true)
        {
            fadeValue = targetObject.GetComponent<Text>().color.a - 0.1f;
            targetObject.GetComponent<Text>().color = new Color(0, 0, 0, fadeValue);
        }else
        {
            targetObject.GetComponent<Text>().text = newText;
            fadeValue = targetObject.GetComponent<Text>().color.a + 0.1f;
            targetObject.GetComponent<Text>().color = new Color(0, 0, 0, fadeValue);
        }

    }
}
