using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionAbove : MonoBehaviour
{
    [SerializeField] private float _barrierHeightOffset;

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponent<Rigidbody>().velocity.y <= 0.1f)
        {
            other.isTrigger = false;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 0.5f, transform.position.z);
        }
        else
        {
            other.isTrigger = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.collider.isTrigger = true;
    }
}
