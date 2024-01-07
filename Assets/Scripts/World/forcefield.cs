using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcefield : MonoBehaviour
{
    public float force= 10f;
    private Rigidbody RB;
    public bool atire;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Grabbable"))
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
