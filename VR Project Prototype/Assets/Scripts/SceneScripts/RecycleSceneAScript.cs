using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleSceneAScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject panel;

    void Update()
    {
        DialogManageScript.ChangeText(text, "把可回收垃圾正確回收，垃圾便會被送到回收廠，得到回收");

        if (Time.timeSinceLevelLoad > 12f)
        {
            DialogManageScript.ChangeText(text, "");
            panel.GetComponent<UnityEngine.UI.Image>().color -= new Color(0, 0, 0, 0.1f);
        }

        if (Time.timeSinceLevelLoad > 16f)
        {
            SceneManager.LoadScene("RecycleSceneB");
        }
    }
}
