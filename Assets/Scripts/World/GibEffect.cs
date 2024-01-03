using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibEffect : MonoBehaviour
{
    public string other;
    public ParticleSystem gibParticleSystem; // Reference to your Particle System

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.name == other)
            {
                Destroy(gameObject);
            }
    }
    
    private void OnDestroy()
    {
        // Check if the Particle System reference is not null and play the effect
        if (gibParticleSystem != null)
        {
            gibParticleSystem.Play();
        }
    }
}