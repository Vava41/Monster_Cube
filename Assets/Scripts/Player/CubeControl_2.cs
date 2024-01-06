using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl_2 : MonoBehaviour
{
    public Green_Leg G1;
    public Red_Leg G2;
    public Blue_Leg G3;

    public Rigidbody rb;

    public float speed = 3f;
    public float speedJoystickH = 3f;
    public float speedJoystickV = 3f;
    public float rotationSpeed = 10f;

    float _horizontalInput;
    float _verticalInput;

    public bool grounded = true;
    public Camera playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        G1 = FindObjectOfType<Green_Leg>();
        G2 = FindObjectOfType<Red_Leg>();
        G3 = FindObjectOfType<Blue_Leg>();
        grounded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Caméra direction
        Vector3 cameraForward = Vector3.Scale(playerCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 cameraRight = Vector3.Scale(playerCamera.transform.right, new Vector3(1, 0, 1)).normalized;
        Vector3 cameraLeft = Vector3.Scale(-playerCamera.transform.right, new Vector3(1, 0, 1)).normalized;
        Vector3 cameraBack = Vector3.Scale(-playerCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        if (grounded == true || G1 == true || G2 == true || G3 == true)
        {
            HandleInput();

            // Clavier Forward
            Vector3 propulsionf = cameraForward;

            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(propulsionf * speed);
            }

            // Clavier Back
            Vector3 propulsionb = cameraBack;

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(propulsionb * speed);
            }

            // Clavier Left
            Vector3 propulsionl = cameraLeft;

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(propulsionl * speed);
            }

            // Clavier Right
            Vector3 propulsionr = cameraRight;

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(propulsionr * speed);
            }


            // Rotation positive clic gauche
            if (Input.GetMouseButton(0)) //0 est le clic gauche
            {
                // Applique une impulsion de rotation autour de l'axe Y
                Vector3 torque = new Vector3(0, rotationSpeed, 0);


                transform.Rotate(torque * Time.deltaTime, Space.World);

            }

            // Rotation positive manette
            if (Input.GetAxis("L2") > 0)
            {
                Vector3 torque = new Vector3(0, rotationSpeed, 0);


                transform.Rotate(torque * Time.deltaTime, Space.World);
            }





            // Rotation negative clic gauche
            if (Input.GetMouseButton(1)) //1 est le clic droit
            {
                // Applique une impulsion de rotation autour de l'axe Y
                Vector3 torque = new Vector3(0, -rotationSpeed, 0);


                transform.Rotate(torque * Time.deltaTime, Space.World);

            }

            // Rotation negative manette
            if (Input.GetAxis("R2") > 0)
            {
                // Applique une impulsion de rotation autour de l'axe Y
                Vector3 torque = new Vector3(0, -rotationSpeed, 0);


                transform.Rotate(torque * Time.deltaTime, Space.World);
            }
        }









        void HandleInput()
        {
            //// R�cup�rer les axes de d�placement de la manette
            //float horizontalInput = Input.GetAxis("Horizontal");
            //float verticalInput = Input.GetAxis("Vertical");

            //// D�finir la direction de la propulsion en fonction des axes
            //Vector3 propulsionDirection = (cameraForward * verticalInput) + (cameraRight * horizontalInput);

            //// Appliquer la force si la manette est utilis�e
            //if (propulsionDirection != Vector3.zero)
            //{
            //    rb.AddForce(propulsionDirection.normalized * speed);
            //}
        }





    }
    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //FMODUnity.RuntimeManager.PlayOneShot("event:/boing");
        grounded = true;
    }
}