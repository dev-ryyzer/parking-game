using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerprefsMaager : MonoBehaviour
{
    public const string Coins = "Coins";
    public static int coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }

    public static void UpdateCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
        coins = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.Save();
    }

    public static void DeleteData()
    {
        coins = 0;
        PlayerPrefs.SetInt("Coins", coins);
        UpdateCoins();
    }
}
