using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeSingleDirection : MonoBehaviour
{
    public bool inverse;
    public float resizeAmount;
    public string resizeDirection;


    public Rigidbody rb;

    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 jump = new Vector3(0f, 1f, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            resize(resizeAmount, resizeDirection);
            //rb.AddForce(jump * speed, ForceMode.Impulse);
        }

        


        

    }

    void resize(float amount, string direction)
    {
        if (direction == "x" && inverse == false)
        {
            transform.position = new Vector3(transform.position.x + (amount / 2), transform.position.y, transform.position.z);
            transform.localScale = new Vector3(transform.localScale.x + amount, transform.localScale.y, transform.localScale.z);
        }
        else if (direction == "y" && inverse == false)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (amount / 2), transform.position.z);
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + amount, transform.localScale.z);
        }
        else if (direction == "z" && inverse == false)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (amount / 2));
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + amount);
        }

        if (direction == "x" && inverse == true)
        {
            transform.position = new Vector3(transform.position.x - (amount / 2), transform.position.y, transform.position.z);
            transform.localScale = new Vector3(transform.localScale.x + amount, transform.localScale.y, transform.localScale.z);
        }
        else if (direction == "y" && inverse == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (amount / 2), transform.position.z);
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + amount, transform.localScale.z);
        }
        else if (direction == "z" && inverse == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (amount / 2));
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + amount);
        }

    }
}