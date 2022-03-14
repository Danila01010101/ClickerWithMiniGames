using System.Collections.Generic;

public class Upgrades
{
    private List<IUpgrade> _upgrades;

    public void Update()
    {
        foreach (IUpgrade upgrade in _upgrades)
        {
            upgrade.Update();
        }
    }
}