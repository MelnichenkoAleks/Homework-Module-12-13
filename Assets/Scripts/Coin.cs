using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameController _gameController;

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player != null)
        {
            _gameController.AddCoin(1);
            gameObject.SetActive(false);
        }
    }
}
