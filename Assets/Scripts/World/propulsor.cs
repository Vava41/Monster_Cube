using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propulsor : MonoBehaviour
{
    public float force= 10f;
    private Rigidbody RB;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (other.CompareTag("Object"))
            {
              RB = other.gameObject.GetComponent<Rigidbody>();
              RB.AddForce(transform.up * force, ForceMode.Force);
            }
        }

        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            if (other.CompareTag("Object"))
            {
                RB = other.gameObject.GetComponent<Rigidbody>();
                RB.AddForce(transform.up * force, ForceMode.Force);
            }
        }


    }
}
