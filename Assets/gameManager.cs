using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    int coin = 0;
    public TextMeshProUGUI textScore;
    public int numberOfCoin = 4;

    public GameObject panelEnd;

    public void coinAdder()
    {
        coin++;
        textScore.text = "Coin : " + coin;
    }

    public void isAllCollected()
    {
        if (coin == numberOfCoin)
        {
            Time.timeScale = 0f;
            panelEnd.SetActive(true);
        }
    }
}