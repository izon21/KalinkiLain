using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    void Update()
    {
        Destroy(gameObject, 3);
        transform.position += transform.forward * speed * Time.deltaTime;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);
        Destroy(gameObject);
    }
}
