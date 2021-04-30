using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalCutsceneScript : MonoBehaviour
{
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] float zoomOutSpeed = 1f;

    void Start()
    {
        DialogManageScript.ChangeText(text1, "");
        DialogManageScript.ChangeText(text2, "");
    }

    // zoom out camera
    void FixedUpdate()
    {
        if(Time.timeSinceLevelLoad > 1f)
        {
            DialogManageScript.ChangeText(text1, "我們的家園-地球-只有一個，如果我們不好好保護它，那我們還有家可歸嗎？");
            text2.GetComponent<Text>().text = "我們的家園-地球-只有一個，如果我們不好好保護它，那我們還有家可歸嗎？";
            text2.GetComponent<Text>().color = new Color(1, 1, 1, text2.GetComponent<Text>().color.a + 0.1f);

            gameObject.transform.position += new Vector3(0.1f * zoomOutSpeed, 0, 0);
        }
        

        if(Time.timeSinceLevelLoad > 15f)
        {
            DialogManageScript.ChangeText(text1, "");
            text2.GetComponent<Text>().text = "";
            text2.GetComponent<Text>().color = new Color(1, 1, 1, text2.GetComponent<Text>().color.a - 0.1f);

        }
        if (Time.timeSinceLevelLoad > 25f)
        {
            SceneManager.LoadScene("EndScene");
        }
        
    }
}
