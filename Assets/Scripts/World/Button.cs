using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public GameObject Door;
    public bool doorIsOpening;

    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 85);
            //if the bool is true open the door

        }
        if (Door.transform.position.y > 30f)
        {
            doorIsOpening = false;
            //if the y of the door is > than 7 we want to stop the door
        }
    }
  
    void OnTriggerEnter(Collider other)
    { //Pour détecter la collision

        doorIsOpening = true;
        //Ouvrir la porte
    }




}