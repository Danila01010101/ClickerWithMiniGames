using System;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private int _coinsAmount;
    public int �oinsAmount{ get; }

    public Action<int> CoinAmountChanged;


    public void AddCoin()
    {
        _coinsAmount++;
        CoinAmountChanged(_coinsAmount);
    }
}