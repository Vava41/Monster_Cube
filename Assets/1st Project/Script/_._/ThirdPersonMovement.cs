using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour

{

    // Facteur d'�chelle pour la face du cube
    public float scaleMultiplier = 2.0f;

    // Vitesse de d�placement du cube
    public float moveSpeed = 5.0f;

    public GameObject Ball;

    public CharacterController controller;
    public Transform cam;



    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;



    // Update is called once per frame
    void Update()
    {


        // V�rifie si la touche espace est enfonc�e
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // R�cup�re le transform du cube
            Transform cubeTransform = transform;

            // R�cup�re la taille initiale du cube
            Vector3 initialScale = cubeTransform.localScale;

            // Calcule la nouvelle taille en multipliant la taille initiale par le facteur d'�chelle
            Vector3 newScale = new Vector3(initialScale.x * scaleMultiplier, initialScale.y, initialScale.z);

            // Met � jour la taille du cube
            cubeTransform.localScale = newScale;

            // D�place le cube vers la droite
            cubeTransform.Translate(Vector3.right * moveSpeed * Time.deltaTime);




            //Player Movement
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;


            if (direction.magnitude >= 0.1f)
            {
                //Camera follow behind
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

                //Smooth Rotation Player
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

                //Player Movement
                controller.Move(moveDir.normalized * speed * Time.deltaTime);
            }


         
        }
    }

}

   



