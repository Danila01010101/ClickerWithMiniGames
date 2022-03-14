using UnityEngine;

public class AutoClicker : BaseClicker
{
    private int _clickCoinAmount = 1;
    private int _clicksAmount = 1;

    public AutoClicker(UpgradeData data)
    {
        _upgradeData = data;
        _currentUpgradeCost = _upgradeData.cost;
    }

    public override void EarnCoins()
    {
        CoinsEarned(_clickCoinAmount * _clicksAmount);
    }

    public override void Upgrade()
    {
        CoinsSpent(_currentUpgradeCost);
        _currentUpgradeCost = (int)(_currentUpgradeCost * _upgradeData.costMultiplier);
        if (_isActive)
        {
            _clicksAmount++;
        }
        else
        {
            _isActive = true;
        }
        Debug.Log("New cost is " + _currentUpgradeCost);
    }
}
