using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script take in computer input to simulate VR control

public class ComputerInput : MonoBehaviour
{
    public float speed = 3;


    void Update()
    {
        // This would rotate the camera by pressing and dragging to simulate VR rotation
        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));

        }

        // Simulate trigger pressed
        if (Input.GetKey(KeyCode.T))
        { 
            SceneManager.LoadScene("360VideoTest");
        }
    }
}
