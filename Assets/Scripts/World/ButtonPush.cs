using UnityEngine;

public class ButtonPush : MonoBehaviour
{
    public GameObject objetAAnimer;
    public string OpeningDoor = "OpeningDoor";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Object"))  // Assure-toi d'avoir un tag "Player" sur ton joueur
        {
            // Appelle la m�thode pour lancer l'animation sur l'objet � animer
            objetAAnimer.SendMessage(OpeningDoor, SendMessageOptions.DontRequireReceiver);
        }
    }
}
