using UnityEngine;

[CreateAssetMenu(fileName = "New Upgrage", menuName = "Upgrade Data", order = 51)]
public class UpgradeData : ScriptableObject
{
    public int cost;
    public float costMultiplier;
    public float tickInterval;
    public int revardAmount;
    public float revardMultiplier;
}
