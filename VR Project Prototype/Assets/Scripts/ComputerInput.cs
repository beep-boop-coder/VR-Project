using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerInput : MonoBehaviour
{
    public float speed = 3;

    void Update()
    {
        //Simulate Camera rotation by dragging

        if(Input.GetMouseButton(0))
        {
            transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));
        }

            // Trigger Pressed
            //if (Input.GetKey(KeyCode.T))
            //{
            //    SceneManager.LoadScene("EndScene");
            //}
        
    }
}