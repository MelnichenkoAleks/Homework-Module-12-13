using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int Count { get; private set; }

    public void AddCoin(int coin)
    {
        Count += coin;
        Debug.Log("Вы подобрали монетку");
    }
}
