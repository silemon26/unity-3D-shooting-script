using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera_moving : MonoBehaviour
{

    public Transform cameraTransform;
    public CharacterController characterController;

    public float moveSpeed = 10f;
    public float jumpSpeed = 10f;
    public float gravity = -20f;
    public float yVelocity = 0;

    void Update()
    {
        MouseRotation();
        KeyboardMove();
    }

    
}
