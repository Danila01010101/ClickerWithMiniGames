using System;

public class Wallet
{
    private AutoClicker _autoClicker;
    private AwerageClicker _accountant;

    public AutoClicker AutoClicker => _autoClicker;
    public AwerageClicker Accountant => _accountant;
    public Action<int> CoinAmountChanged;

    public void Initialize()
    {
        CoinAmountChanged?.Invoke(GlobalWallet.Instance.GetMoneyAmount());
    }

    public void Update()
    {
        _autoClicker.Update();
    }

    public Wallet(UpgradeData autoClickerData, UpgradeData accountantData)
    {
        _autoClicker = new AutoClicker(autoClickerData);
        _accountant = new AwerageClicker(accountantData);
    }

    public void ActivateUpgrade(WalletPresenter.Upgrades upgrade)
    {
        switch (upgrade)
        {
            case WalletPresenter.Upgrades.AutoClicker:
                BuyUprade(_autoClicker);
                break;
            case WalletPresenter.Upgrades.Buhgalter:
                BuyUprade(_accountant);
                break;
        }
    }

    private void BuyUprade(BaseClicker upgradeToBuy)
    {
        if (GlobalWallet.Instance.GetMoneyAmount() >= upgradeToBuy.Cost)
        {
            upgradeToBuy.Upgrade();
        }
    }

    public void SpentCoins(int amount)
    {
        GlobalWallet.Instance.SpendMoney(amount);
        CoinAmountChanged?.Invoke(GlobalWallet.Instance.GetMoneyAmount());
    }

    public void AddCoins(int amount)
    {
        GlobalWallet.Instance.AddMoney(amount);
        CoinAmountChanged?.Invoke(GlobalWallet.Instance.GetMoneyAmount());
    }

    public void AddClickCoin()
    {
        GlobalWallet.Instance.AddMoney(1);
        CoinAmountChanged?.Invoke(GlobalWallet.Instance.GetMoneyAmount());
    }
}