using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj : MonoBehaviour
{
    private bool carried= false;
    private bool col= false;
    // Update is called once per frame
    
    void OnColliderEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Hand"))
        {
            //GetComponent<Rigidbody>().isKinematic= true;
            transform.position= collision.transform.position;
        }

    }
}
