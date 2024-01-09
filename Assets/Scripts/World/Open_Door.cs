using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour
{
    public Animation doorOpening;
    public string fmodEventPath = "event:/FolderName/YourEventPath";
    public string nomAnimation = "Door";

 

    // La m�thode appel�e depuis le script CollisionController
    public void OpeningDoor()
    {
        doorOpening = GetComponent<Animation>();
        doorOpening.Play();
        FMODUnity.RuntimeManager.PlayOneShot(fmodEventPath, transform.position);
    }
}

