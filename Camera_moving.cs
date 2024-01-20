using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera_moving : MonoBehaviour
{

    public Camera Cam;

    private float camRotSpeed = 10;
    private float sensitive = 500;

    void CameraViewControl()
    {
        float rotx = Input.GetAxis("Mouse Y");
        float rotY = Input.GetAxis("Mouse X");

        transform.localEulerAngles = new Vector3(rotx, rotY, 0) * sensitive * Time.deltaTime;

    }

    
}
