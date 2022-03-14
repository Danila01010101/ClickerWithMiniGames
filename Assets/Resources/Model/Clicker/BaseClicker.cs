using System;
using UnityEngine;

public abstract class BaseClicker : IUpgrade
{
    private float _lastTickTime = 0;

    protected bool _isActive = false;
    protected UpgradeData _upgradeData;
    protected int _currentUpgradeCost;

    public int Cost => _currentUpgradeCost;

    public Action<int> CoinsEarned;
    public Action<int> CoinsSpent;

    public void Update()
    {
        if (_isActive)
        {
            if (Time.time - _lastTickTime > _upgradeData.tickInterval)
            {
                EarnCoins();
                _lastTickTime = Time.time;
            }
        }
    }

    public abstract void EarnCoins();
    public abstract void Upgrade();
}
