using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent(typeof(ICoinCollector)))
        {
            //GlobalWallet.Instance.AddMoney(1);
            if (other.GetComponent<Bullet>())
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
