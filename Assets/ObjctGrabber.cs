using UnityEngine;

public class ObjectGrabber : MonoBehaviour
{
    private bool isGrabbing = false;
    private Transform grabbedObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrabbing)
            {
                RelaxObject();
            }
            else
            {
                GrabObject();
            }
        }
    }

    void GrabObject()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Grabbable"))
            {
                isGrabbing = true;
                grabbedObject = hit.collider.transform;

                // Disable physics for the grabbed object
                grabbedObject.GetComponent<Rigidbody>().isKinematic = true;

                // Attach the grabbed object to the player
                grabbedObject.SetParent(transform);
            }
        }
    }

    void RelaxObject()
    {
        if (grabbedObject != null)
        {
            // Enable physics for the grabbed object
            grabbedObject.GetComponent<Rigidbody>().isKinematic = false;

            // Detach the grabbed object from the player
            grabbedObject.SetParent(null);

            isGrabbing = false;
            grabbedObject = null;
        }
    }
}
