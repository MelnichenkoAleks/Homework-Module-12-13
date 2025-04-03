using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.GetComponent<Coin>();

        if (coin != null)
        {
            _wallet.AddCoin(coin.Count);
            Destroy(coin.gameObject);
        }
    }
}
