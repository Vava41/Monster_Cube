using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public Rigidbody rb;

    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 propulsion = new Vector3(-1f, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.A))
        {

            rb.AddForce(propulsion * speed, ForceMode.Impulse);
        }

        Vector3 jump = new Vector3(0f, 1f, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jump * speed, ForceMode.Impulse);
        }


    }


   

          



    }


