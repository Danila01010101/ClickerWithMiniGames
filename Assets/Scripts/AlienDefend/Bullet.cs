using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    [SerializeField] private float boundOne = 0f;
    [SerializeField] private float boundTwo = -30f;

    public static Action OnEnemyShot;


    void Update()
    {
        transform.Translate(0, -1 * Time.deltaTime * speed, 0);

        if (transform.position.x > boundOne)
        {
            Destroy(gameObject);
        }   
        else if (transform.position.x < boundTwo)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MonsterMove>())
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            OnEnemyShot?.Invoke();
        }
    }
}