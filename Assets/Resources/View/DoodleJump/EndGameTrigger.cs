using System;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
    public static Action OnGameOver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DoodleJumpPresenter>())
        {
            OnGameOver?.Invoke();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<DoodleJumpPresenter>())
        {
            OnGameOver?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
