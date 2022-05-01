using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalWallet : MonoBehaviour
{
    private string _saveMoneyName = "moneyAmount";
    public static GlobalWallet Instance;


    public int GetMoneyAmount()
    {
        return PlayerPrefs.GetInt(_saveMoneyName, 0);
    }

    public void AddMoney(int amount)
    {
        PlayerPrefs.GetInt(_saveMoneyName, GetMoneyAmount() + amount);
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
