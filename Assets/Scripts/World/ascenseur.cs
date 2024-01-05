using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascenceur : MonoBehaviour
{
    public float deplacement = 5f;
    private float compteur = 0f;
    public float vitesse = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        compteur += Time.deltaTime;
        FixedUpdate();
    }
    void FixedUpdate()
    {
        transform.Translate(0, vitesse * Time.deltaTime, 0);
        if (compteur >= deplacement)
        {
            vitesse = -vitesse;
            compteur = 0f;
            FixedUpdate();
        }
    }
}
