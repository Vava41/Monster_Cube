using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float strenght = 10f;
    Vector3 vecteur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            vecteur = collision.transform.position - transform.position;
            Rigidbody RB = collision.gameObject.GetComponent<Rigidbody>();
            RB.AddForce(vecteur * strenght, ForceMode.Impulse);
        }
    }
}
