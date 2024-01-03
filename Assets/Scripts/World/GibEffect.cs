using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibEffect : MonoBehaviour
{
    public string other;
    public ParticleSystem gibParticleSystem; // Reference to your Particle System
    public float delayTime = 0.001f;
    public GameObject objectWithMeshRenderer;

    private void OnCollisionEnter(Collision collision)
    {
        MeshRenderer meshRenderer = objectWithMeshRenderer.GetComponent<MeshRenderer>();
       if (collision.gameObject.name == other)
            {
                meshRenderer.enabled = false;
                gibParticleSystem.Play();
                StartCoroutine(DestroyWithDelay());
            }
    }
    IEnumerator DestroyWithDelay()
    {
        yield return new WaitForSeconds(delayTime); // Wait for the specified delay time
        Destroy(gameObject); // Destroy the GameObject after the delay
    }
}