using System;
using UnityEngine;

public class ShopButtonActions : MonoBehaviour
{
    public Action<WalletPresenter.Upgrades> ActivateUpgradeButtonPressed;

    public void ActivateAutoClicker()
    {
        ActivateUpgradeButtonPressed?.Invoke(WalletPresenter.Upgrades.AutoClicker);
    }

    public void ActivateAccountant()
    {
        ActivateUpgradeButtonPressed?.Invoke(WalletPresenter.Upgrades.Buhgalter);
    }
}
