using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Spawn : MonoBehaviour
{

    public Transform Green;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Green != null)
        {
            
            transform.position = Green.position;
            transform.rotation = Green.rotation;
        }
    }
}
