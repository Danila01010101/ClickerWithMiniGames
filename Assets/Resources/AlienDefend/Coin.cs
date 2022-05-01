using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float speed = 35f;

    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent(typeof(ICoinCollector)))
        {
            //GlobalWallet.Instance.AddMoney(1);
            Destroy(gameObject);
        }
    }
}
