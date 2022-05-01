using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public static Action OnHealthAdding;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>())
        {
            OnHealthAdding?.Invoke();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
