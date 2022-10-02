using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHitClass : MonoBehaviour
{

    [SerializeField] float distance = 150f;
    [SerializeField] ParticleSystem fire;
    [SerializeField] ParticleSystem lavaParticle;
    [SerializeField] ParticleSystem yellowParticle;
    [SerializeField] ParticleSystem waterParticle;
    [SerializeField] AudioSource weaponPlayerSound;
    [SerializeField] Transform cameraTransform1;
    [SerializeField] Transform cameraTransform2;




    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(cameraTransform1.position, cameraTransform1.forward, out hit, distance))
            {

                if (hit.collider.name == "SphereLava1")
                {
                    GameManager.instance.totalPointsFunction();
                    lavaParticle.transform.position = hit.point;
                    lavaParticle.Play();
                }
                    
                if (hit.collider.name == "SphereLava2")
                {
                    GameManager.instance.totalPointsFunction();
                    lavaParticle.transform.position = hit.point;
                    lavaParticle.Play();
                }
                
                if (hit.collider.name == "SphereLava3")
                {
                    GameManager.instance.totalPointsFunction();
                    lavaParticle.transform.position = hit.point;
                    lavaParticle.Play();
                }
                    
                 
                if (hit.collider.name == "SphereYellow")
                {
                    GameManager.instance.totalPointsFunction();
                    yellowParticle.transform.position = hit.point;
                    yellowParticle.Play();
                }
                    
                    
                 
                if (hit.collider.name == "SphereWater")
                {
                    GameManager.instance.totalPointsFunction();
                    waterParticle.transform.position = hit.point;
                    waterParticle.Play();
                }
                    
                    
                
            }


            if (Physics.Raycast(cameraTransform2.position, cameraTransform2.forward, out hit, distance))
            {

                if (hit.collider.name == "SphereLava1")
                {
                    GameManager.instance.totalPointsFunction();
                    lavaParticle.transform.position = hit.point;
                    lavaParticle.Play();
                }

                if (hit.collider.name == "SphereLava2")
                {
                    GameManager.instance.totalPointsFunction();
                    lavaParticle.transform.position = hit.point;
                    lavaParticle.Play();
                }

                if (hit.collider.name == "SphereLava3")
                {
                    GameManager.instance.totalPointsFunction();
                    lavaParticle.transform.position = hit.point;
                    lavaParticle.Play();
                }


                if (hit.collider.name == "SphereYellow")
                {
                    GameManager.instance.totalPointsFunction();
                    yellowParticle.transform.position = hit.point;
                    yellowParticle.Play();
                }



                if (hit.collider.name == "SphereWater")
                {
                    GameManager.instance.totalPointsFunction();
                    waterParticle.transform.position = hit.point;
                    waterParticle.Play();
                }

            }  




            if (Input.GetMouseButtonDown(0))
            {
                fire.Play();
                weaponPlayerSound.Play();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                fire.Stop();
                weaponPlayerSound.Stop();
            }

          




        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(cameraTransform1.position, cameraTransform1.forward * distance);
        Gizmos.DrawRay(cameraTransform2.position, cameraTransform2.forward * distance);
    }
}
