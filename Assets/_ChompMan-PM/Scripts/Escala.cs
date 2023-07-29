using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{
    private bool hasCollided = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere") && !hasCollided)
        {
            Transform sphereTransform = collision.gameObject.transform;
            sphereTransform.localScale *= 0.5f;

            hasCollided = true;
        }
    }
}
