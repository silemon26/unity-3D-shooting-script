using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigid;

    public Transform cameraTransform;

    public CharacterController controller;
    public float JumpForce;
    public float MoveSpeed;
    public float Yvelocity = 0;
    public float Gravity = -9.8f;
    
   

    private bool IsJumping;
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();   
        controller=GetComponent<CharacterController>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movedirection = new Vector3(h, 0, v);

        movedirection = cameraTransform.TransformDirection(movedirection);
        // 카메라 위치
        movedirection *= MoveSpeed;

        if (controller.isGrounded)
        {
            Yvelocity = 0;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Yvelocity = JumpForce;
            }
        }
        Yvelocity += Gravity * Time.deltaTime;

        movedirection.y = Yvelocity;

        controller.Move(movedirection * Time.deltaTime);
    }

    

 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsJumping = false;
        }
    }
}
