public class AwerageClicker : BaseClicker
{
    public AwerageClicker(UpgradeData data)
    {
        _upgradeData = data;
        _currentUpgradeCost = _upgradeData.cost;
    }

    public override void EarnCoins()
    {
        CoinsEarned(_clickCoinAmount);
    }

    public override void Upgrade()
    {
        CoinsSpent(_currentUpgradeCost);
        _currentUpgradeCost = (int)(_currentUpgradeCost * _upgradeData.costMultiplier);
        if (_isActive)
        {
            _clickCoinAmount = (int)(_clickCoinAmount * _upgradeData.revardMultiplier);
        }
        else
        {
            _isActive = true;
        }
    }
}