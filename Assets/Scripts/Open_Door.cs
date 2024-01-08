using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour
{
    public Animation doorOpening;
    


    public string nomAnimation = "Door";

 

    // La méthode appelée depuis le script CollisionController
    public void OpeningDoor()
    {
        doorOpening = GetComponent<Animation>();
        doorOpening.Play();
    }
}

