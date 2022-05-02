using UnityEngine;

public class GlobalWallet : MonoBehaviour
{
    private string _saveMoneyName = "moneyAmount";
    public static GlobalWallet Instance;

    private void Awake()
    {
        Instance = this;
    }

    public int GetMoneyAmount()
    {
        return PlayerPrefs.GetInt(_saveMoneyName, 0);
    }

    public void AddMoney(int amount)
    {
        int newAmount = GetMoneyAmount() + amount;
        PlayerPrefs.SetInt(_saveMoneyName, newAmount);
    }

    public bool SpendMoney(int amount)
    {
        int moneyAmount = GetMoneyAmount();
        if (moneyAmount >= amount)
        {
            PlayerPrefs.SetInt(_saveMoneyName, moneyAmount - amount);
            return true;
        }
        return false;
    }
}
