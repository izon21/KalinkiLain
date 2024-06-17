using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramplen : MonoBehaviour
{
    [SerializeField] private float force;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);

        }
    }
}
