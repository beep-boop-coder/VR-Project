using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleSceneBScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject panel;

    void Update()
    {
        DialogManageScript.ChangeText(text, "垃圾回收後，便可送去其他地方重新使用，避免了垃圾本來會對環境造成的許多傷害");

        if (Time.timeSinceLevelLoad > 10f)
        {
            DialogManageScript.ChangeText(text, "");
            panel.GetComponent<UnityEngine.UI.Image>().color -= new Color(0, 0, 0, 0.1f);
        }

        if (Time.timeSinceLevelLoad > 25f)
        {
            SceneManager.LoadScene("InteractiveSceneA");
        }
    }
}
