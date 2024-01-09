using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propulsor : MonoBehaviour
{
    public float force= 10f;
    private Rigidbody RB;
    FMOD.Studio.EventInstance vac;
    // Start is called before the first frame update
    private void Start()
    {
        vac = FMODUnity.RuntimeManager.CreateInstance("event:/player/powers/vaccum");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            vac.start();
        }
        if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            vac.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        }
    }
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
