using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins_Manager : MonoBehaviour
{
    public static void DecreaseCoins(int decrement)
    {
        if (PlayerprefsMaager.coins > 0)
        {
            PlayerprefsMaager.coins -= decrement;
        }
        PlayerprefsMaager.UpdateCoins();
    }

    public static void IncreaseCoins(int increment)
    {
        PlayerprefsMaager.coins += increment;
        PlayerprefsMaager.UpdateCoins();
    }

    public static void DeleteData()
    {
        PlayerprefsMaager.DeleteData();
    }
}
