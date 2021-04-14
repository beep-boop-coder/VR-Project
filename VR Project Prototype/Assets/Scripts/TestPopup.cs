using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPopup : MonoBehaviour
{
    public GameObject Text;
    
    void Start()
    {
        Text.SetActive(false);
    }

    //public static void ToggleTextVisibility()
    //{
    //    GameObject Text = new GameObject();
    //    Text = GameObject.Find("Text");
    //    Text.SetActive(true);
    //    Debug.Log("Object toggled");
    //}
}
