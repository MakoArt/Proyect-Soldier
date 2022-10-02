using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] Animator anim;
    [SerializeField] float speed = 10f;
    [SerializeField] float _x;
    [SerializeField] float _y;

    Vector3 movement;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        
    }


    void Update()
    {
        //Movimiento del jugador 

        _x = Input.GetAxis("Horizontal");
        _y = Input.GetAxis("Vertical");

        movement = transform.right * _x + transform.forward * _y;

        characterController.Move(movement * speed * Time.deltaTime);


        //Animations

        anim.SetFloat("velX", _x);
        anim.SetFloat("velY", _y);

        //transform player 


    }

}
