using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins_Display : MonoBehaviour
{
    private Text Coins_Text;
    // Start is called before the first frame update
    void Start()
    {
        Coins_Text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        string[] temp = Coins_Text.text.Split(':');
        Coins_Text.text = temp[0] + ": " + PlayerprefsMaager.coins;
    }
}
