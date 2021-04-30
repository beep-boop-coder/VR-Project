using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashSceneAScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject panel;

    void Update()
    {

        DialogManageScript.ChangeText(text, "不把垃圾正確分類，垃圾便會被送到你現在見到的垃圾收集站");

        if (Time.timeSinceLevelLoad > 7f)
        {
            DialogManageScript.ChangeText(text, "");
            panel.GetComponent<UnityEngine.UI.Image>().color -= new Color(0, 0, 0, 0.1f);
        }

        if (Time.timeSinceLevelLoad > 10f)
        {
            SceneManager.LoadScene("TrashSceneB");
        }
    }
}
