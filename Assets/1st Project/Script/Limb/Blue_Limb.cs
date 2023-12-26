using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBlue_Limb : MonoBehaviour
{
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
        transform.localScale = new Vector3(_parent.localScale.x / 2, _parent.localScale.y / 2, _parent.localScale.z / 2);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_input))
        {
            resize(resizeAmount, resizeDirection);
        }
    }



    void resize(float amount, string direction)
    {

        //Spawn Blue Limb
        if (direction == "x" && inverse == false)
        {
            transform.position = new Vector3(transform.position.x + (amount / 2), transform.position.y, transform.position.z);
            transform.localScale = new Vector3(transform.localScale.x + amount, transform.localScale.y, transform.localScale.z);
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