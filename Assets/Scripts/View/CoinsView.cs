using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsAmountText;

    public void UpdateScore(int currentAmount)
    {
        _coinsAmountText.text = currentAmount.ToString();
    }
}
