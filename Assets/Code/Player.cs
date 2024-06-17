using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] int health = 100;

    [SerializeField] int coins;
    [SerializeField] int maxHealth = 100;
    [SerializeField] float speed = 10f;
    [SerializeField] float speedIncrease = 110f;
    [SerializeField] float speedDecrease = 5f;
    [SerializeField] GameObject firball;
    [SerializeField] Transform attackPoint;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] Slider slider;


    public void TakeDamage(int damage)
    {
        health -= damage;
        //print("Здоровье" + health);
        slider.value = health;
        if (health <= 0)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
    public void CollectCoins()
    {
        coins++;
        _text.text = coins.ToString();
        //print("Кол-во монеток: " + coins);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            Instantiate(firball, attackPoint.position, attackPoint.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Line"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity += new Vector3(0f, speedIncrease, 0f);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Line"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity -= new Vector3(0f, speedDecrease, 0f);
        }
    }

}
