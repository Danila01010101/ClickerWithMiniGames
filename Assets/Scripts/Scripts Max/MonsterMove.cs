using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float boundOne = 1f;
    [SerializeField] private float boundTwo = -1f;
    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x > boundOne)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < boundTwo)
        {
            Destroy(gameObject);
        }
    }
}
