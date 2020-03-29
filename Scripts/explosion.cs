using UnityEngine;
using System.Collections;

// Applies an explosion force to all nearby rigidbodies
public class explosion : MonoBehaviour
{
    public float radius;
    public float power;
    

    public void dikkeboem()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }
    }
    public void kleineeboem()
    {
        Debug.Log("i've noticed you are depressed");
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power/3, explosionPos, radius, 3.0F);
        }
    }
}