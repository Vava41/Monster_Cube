using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Limb : MonoBehaviour
{
    public GameObject Player;
   
    public bool inverse;

    public float resizeAmount;
    public string resizeDirection;

    public int limite = 10;
    private int compteur = 0;

    public Transform _parent;
    public string _input;

   
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3 (_parent.localScale.x / 2, _parent.localScale.y / 2, _parent.localScale.z / 2);
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        if (Input.GetKeyDown(_input))
        {
            resize(resizeAmount, resizeDirection);
        }
    }


    void resize(float amount, string direction)
    {


        //Spawn Green Limb
        if (direction == "y" && inverse == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (amount / 2), transform.position.z);
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + amount, transform.localScale.z);
            Quaternion rotation = (Player.transform.rotation);
            compteur += 1;
        }



        //Limite
        if (compteur == limite)
        {
            compteur = 0;
            transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);
            transform.localScale = new Vector3(_parent.localScale.x / 2, _parent.localScale.y / 2, _parent.localScale.z / 2);
        }


    }
}