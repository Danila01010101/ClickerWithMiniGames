using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent(typeof(ICoinCollector)))
        {
            GlobalWallet.Instance.AddMoney(1);
            if (other.GetComponent<Bullet>())
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent(typeof(ICoinCollector)))
        {
            GlobalWallet.Instance.AddMoney(1);
            if (collision.gameObject.GetComponent<Bullet>())
            {
                Destroy(collision.gameObject.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
