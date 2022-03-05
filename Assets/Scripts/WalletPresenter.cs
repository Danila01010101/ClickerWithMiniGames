using UnityEngine;

public class WalletPresenter : MonoBehaviour
{
    [SerializeField] private CoinsView _coinsView;
    [SerializeField] private ClickDetector _clickDetector;
    private Wallet _wallet;


    private void Awake()
    {
        _wallet = new Wallet();
    }

    private void OnEnable()
    {
        _clickDetector.CharacterClicked += _wallet.AddCoin;
        _wallet.CoinAmountChanged += _coinsView.UpdateScore;
    }

    private void OnDisable()
    {
        _clickDetector.CharacterClicked -= _wallet.AddCoin;
        _wallet.CoinAmountChanged -= _coinsView.UpdateScore;
    }
}
