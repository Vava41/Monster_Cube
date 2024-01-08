using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public Animation Door_Opening;

    public GameObject Door;
    public bool doorIsOpening;


    void DoorOpening()
    {
        Door_Opening = GetComponent<Animation>();
        Door_Opening.Play();
    }


    private void Start()
    {
        DoorOpening();
    }


    void Update()


     
    {
        //if (doorIsOpening == true)
        //{

        //    Door_Opening = GetComponent<Animation>();
        //    Door_Opening.Play();
        //    //Door.transform.Translate(Vector3.up * Time.deltaTime * 85);
        //    //if the bool is true open the door

        //}
        //if (Door.transform.position.y > 30f)
        //{
        //    doorIsOpening = false;
        //    //if the y of the door is > than 7 we want to stop the door
        //}
    }
  
    void OnTriggerEnter(Collider other)
    { //Pour détecter la collision

        DoorOpening();
        //Ouvrir la porte
    }




}