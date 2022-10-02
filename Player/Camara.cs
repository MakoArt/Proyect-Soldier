using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    [SerializeField] Transform playerBody;
    [SerializeField] float mouseSensibility;

    [SerializeField] float minClamp;
    [SerializeField] float maxClamp;
    [SerializeField] Animator anim;

    [SerializeField] GameObject camara1;
    [SerializeField] GameObject camara2;

    




    private float xRotation = 0;
    private float yRotation = 0;
    private float mouseX;
    private float mouseY;

    



   
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        //Rotacion horizontal de la camara 

        playerBody.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        yRotation += mouseX;
         
        xRotation = Mathf.Clamp(xRotation, minClamp, maxClamp);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        //apuntar

        if (Input.GetMouseButtonDown(1))
        {
        
            anim.SetBool("weaponUp", true);
            camara1.SetActive(false);
            camara2.SetActive(true);
        }

        if (Input.GetMouseButtonUp(1))
        {
          
            anim.SetBool("weaponUp", false);
            camara1.SetActive(true);
            camara2.SetActive(false);
        }


      

    }
}
