using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcefield : MonoBehaviour
{
    public float force= 10f;
    private Rigidbody RB;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        RB= other.gameObject.GetComponent<Rigidbody>();
        RB.AddForce(-transform.forward * force, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
