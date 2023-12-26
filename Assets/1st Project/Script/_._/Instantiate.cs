using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    public GameObject Projectiles;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnProjectiles();

        }


        void SpawnProjectiles()
        {
            Instantiate(Projectiles, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        }
    }
}