using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
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
    void Update()
    {
        if (grounded== true || G1== true || G2 == true || G3 == true)
        {
            HandleInput();


            Vector3 propulsionf = Vector3.forward;

            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(propulsionf * speed);
            }


            Vector3 propulsionb = Vector3.back;

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(propulsionb * speed);
            }


            Vector3 propulsionl = Vector3.left;

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(propulsionl * speed);
            }


            Vector3 propulsionr = Vector3.right;

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(propulsionr * speed);
            }



            if (Input.GetMouseButton(0)) //0 est le clic gauche
            {
                // Applique une impulsion de rotation autour de l'axe Y
                Vector3 torque = new Vector3(0, rotationSpeed, 0);


                transform.Rotate(torque * Time.deltaTime, Space.World);

            }

            if (Input.GetAxis("L2") > 0)
            {
                Vector3 torque = new Vector3(0, rotationSpeed, 0);


                transform.Rotate(torque * Time.deltaTime, Space.World);
            }






            if (Input.GetMouseButton(1)) //1 est le clic droit
            {
                // Applique une impulsion de rotation autour de l'axe Y
                Vector3 torque = new Vector3(0, -rotationSpeed, 0);


                transform.Rotate(torque * Time.deltaTime, Space.World);

            }


            if (Input.GetAxis("R2") > 0)
            {
                // Applique une impulsion de rotation autour de l'axe Y
                Vector3 torque = new Vector3(0, -rotationSpeed, 0);


                transform.Rotate(torque * Time.deltaTime, Space.World);
            }
        }
        








        void HandleInput()
        {
            // Récupérer les axes de déplacement de la manette
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Définir la direction de la propulsion en fonction des axes
            Vector3 propulsionDirection = new Vector3(horizontalInput, 0f, verticalInput);

            // Appliquer la force si la manette est utilisée
            if (propulsionDirection != Vector3.zero)
            {
                rb.AddForce(propulsionDirection.normalized * speed);
            }
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