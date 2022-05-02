using System;
using UnityEngine;

public class ShopButtonActions : MonoBehaviour
{
    [SerializeField] private CoinsView _coinsView;
    public Action<WalletPresenter.Upgrades> ActivateUpgradeButtonPressed;
    public GameObject[] _activatableGameObject;

    private void Awake()
    {
        foreach (GameObject gameObject in _activatableGameObject)
        {
            if (PlayerPrefs.GetInt(gameObject.name, 0) == 1)
            {
                gameObject.SetActive(true);
            }
        }
    }

    public void ActivateAutoClicker()
    {
        ActivateUpgradeButtonPressed?.Invoke(WalletPresenter.Upgrades.AutoClicker);
    }

    public void ActivateAccountant()
    {
        ActivateUpgradeButtonPressed?.Invoke(WalletPresenter.Upgrades.Buhgalter);
    }

    public void BuyObjectOnClick(GameObject gameObject)
    {
        if (!gameObject.activeSelf && GlobalWallet.Instance.SpendMoney(500))
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt(gameObject.name, 1);
            _coinsView.UpdateScore(GlobalWallet.Instance.GetMoneyAmount());
        }
    }
}
