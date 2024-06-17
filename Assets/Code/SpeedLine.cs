using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLine : MonoBehaviour
{
    [SerializeField] float speedFactor = 1.5f;

    private void OnCollisionEnter(Collision collision)
    {

        FirstPersonMovement player = collision.gameObject.GetComponent<FirstPersonMovement>();
        player.speed *= speedFactor;

    }
    void OnCollisionExit(Collision collision) 
    {
        FirstPersonMovement player = collision.gameObject.GetComponent<FirstPersonMovement>();
        player.speed /= speedFactor;

    }

}
