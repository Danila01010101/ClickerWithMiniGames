using System;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float boundOne = 6.5f;
    [SerializeField] private float boundTwo = -50f;

    public static Action<int> OnBorderCrossed;

    public void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x > boundOne)
        {
            Destroy(gameObject);
            OnBorderCrossed?.Invoke(20);
        }
        else if (transform.position.x < boundTwo)
        {
            Destroy(gameObject);
        }
    }
}
