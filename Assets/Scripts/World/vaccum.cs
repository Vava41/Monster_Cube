using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaccum : MonoBehaviour
{
    public float force = 10f;
    private Rigidbody RB;
    FMOD.Studio.EventInstance vac;
    // Start is called before the first frame update
    private void Start()
    {
        vac = FMODUnity.RuntimeManager.CreateInstance("event:/player/powers/vaccum");
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.R))
        {
            if (other.CompareTag("Object"))
            {
                RB = other.gameObject.GetComponent<Rigidbody>();
                RB.AddForce(-transform.up * force, ForceMode.Force);
            }
        }

        if (Input.GetKey(KeyCode.Joystick1Button3))
        {
            if (other.CompareTag("Object"))
            {
                RB = other.gameObject.GetComponent<Rigidbody>();
                RB.AddForce(-transform.up * force, ForceMode.Force);
            }
        }
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            vac.start();
        }
        if (Input.GetKeyUp(KeyCode.R) || Input.GetKeyUp(KeyCode.Joystick1Button3))
        {
            vac.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        }

    }
}
