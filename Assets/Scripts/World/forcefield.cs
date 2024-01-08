using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcefield : MonoBehaviour
{
    public float force = 10f;
    private Rigidbody RB;
    public bool atire;
    public string _input;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
        {
            if (other.CompareTag("Object"))
            {
                if (atire == false)
                {
                    RB = other.gameObject.GetComponent<Rigidbody>();
                    RB.AddForce(transform.up * force, ForceMode.Force);
                }
                else
                {
                    RB = other.gameObject.GetComponent<Rigidbody>();
                    RB.AddForce(-transform.up * force, ForceMode.Force);
                }
            }
        }
    }
}