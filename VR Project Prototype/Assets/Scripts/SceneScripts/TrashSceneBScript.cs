using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashSceneBScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject panel;

    void Update()
    {
        DialogManageScript.ChangeText(text, "接著垃圾便會被送到堆填區，佔用空間之餘也會對環境造成傷害");

        if (Time.timeSinceLevelLoad > 7f)
        {
            DialogManageScript.ChangeText(text, "");
            panel.GetComponent<UnityEngine.UI.Image>().color -= new Color(0, 0, 0, 0.1f);
        }

        if (Time.timeSinceLevelLoad > 10f)
        {
            SceneManager.LoadScene("InteractiveSceneA");
        }
    }
}
