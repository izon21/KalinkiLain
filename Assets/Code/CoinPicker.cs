using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    private void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 83);
    }
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.CollectCoins();
        Destroy(gameObject);
    }
}