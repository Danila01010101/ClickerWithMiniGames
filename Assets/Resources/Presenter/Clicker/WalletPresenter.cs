using UnityEngine;

public class WalletPresenter : MonoBehaviour
{
    [SerializeField] private CoinsView _coinsView;
    [SerializeField] private ClickDetector _clickDetector;
    [SerializeField] private ShopButtonActions _shopActions;
    [SerializeField] private UpgradeData _autoClickerData;
    [SerializeField] private UpgradeData _accountantData;

    private Wallet _wallet;

    public enum Upgrades { AutoClicker, Buhgalter }

    private void Awake()
    {
        _wallet = new Wallet(_autoClickerData, _accountantData);
    }

    private void Update()
    {
        _wallet.Update();
    }

    private void OnEnable()
    {
        _clickDetector.CharacterClicked += _wallet.AddClickCoin;
        _wallet.CoinAmountChanged += _coinsView.UpdateScore;
        _wallet.AutoClicker.CoinsEarned += _wallet.AddCoins;
        _wallet.AutoClicker.CoinsSpent += _wallet.SpentCoins;
        _wallet.Accountant.CoinsEarned += _wallet.AddCoins;
        _wallet.Accountant.CoinsSpent += _wallet.SpentCoins;
        _shopActions.ActivateUpgradeButtonPressed += _wallet.ActivateUpgrade;
    }

    private void OnDisable()
    {
        _clickDetector.CharacterClicked -= _wallet.AddClickCoin;
        _wallet.CoinAmountChanged -= _coinsView.UpdateScore;
        _wallet.AutoClicker.CoinsEarned -= _wallet.AddCoins;
        _wallet.AutoClicker.CoinsSpent -= _wallet.SpentCoins;
        _wallet.Accountant.CoinsEarned -= _wallet.AddCoins;
        _wallet.Accountant.CoinsSpent -= _wallet.SpentCoins;
        _shopActions.ActivateUpgradeButtonPressed -= _wallet.ActivateUpgrade;
    }
}
