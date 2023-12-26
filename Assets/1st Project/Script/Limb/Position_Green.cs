using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position_Green : MonoBehaviour
{


    public float verticalSpacing = 0.5f;

    //public float speed = 2;

    public string _input;

    public GameObject PositionGreen;
    public GameObject greenLimb;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(_input))
        {

            
            transform.position -= new Vector3(0, verticalSpacing, 0);
            ObjectApparition();

            //Instantiate(greenLimb, new Vector3(0, PositionGreen.transform.position.y, 0), Quaternion.identity);


            //transform.position -= new Vector3(0, verticalSpacing, 0);

        }




    }

    void ObjectApparition()
    {

        GameObject newObject = Instantiate(greenLimb);

        //
     }
}    