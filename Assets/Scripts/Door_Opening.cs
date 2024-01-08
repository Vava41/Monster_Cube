using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Opening : MonoBehaviour
{

    public Animation doorOpening;

    public GameObject Button;


    void OpeningDoor()
    {
        doorOpening = GetComponent<Animation>();
        doorOpening.Play();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpeningDoor();
        }
    }



}
