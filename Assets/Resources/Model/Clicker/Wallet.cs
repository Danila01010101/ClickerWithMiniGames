using System;

public class Wallet
{
    private int _coinsAmount;
    public int ÑoinsAmount{ get; }

    private AutoClicker _autoClicker;

    public AutoClicker AutoClicker => _autoClicker;
    public Action<int> CoinAmountChanged;

    public void Update()
    {
        _autoClicker.Update();
    }

    public Wallet(UpgradeData autoClickerData)
    {
        _autoClicker = new AutoClicker(autoClickerData);
    }

    public void ActivateUpgrade(WalletPresenter.Upgrades upgrade)
    {
        switch (upgrade)
        {
            case WalletPresenter.Upgrades.AutoClicker:
                BuyUprade(_autoClicker);
                break;
        }
    }

    private void BuyUprade(BaseClicker upgradeToBuy)
    {
        if (_coinsAmount >= upgradeToBuy.Cost)
        {
            upgradeToBuy.Upgrade();
        }
    }
    public void SpentCoins(int amount)
    {
        _coinsAmount -= amount;
        CoinAmountChanged?.Invoke(_coinsAmount);
    }

    public void AddCoins(int amount)
    {
        _coinsAmount += amount;
        CoinAmountChanged?.Invoke(_coinsAmount);
    }

    public void AddClickCoin()
    {
        _coinsAmount++;
        CoinAmountChanged?.Invoke(_coinsAmount);
    }
}