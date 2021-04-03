using System;
using UnityEngine;
using UnityEngine.UI;

public class DataStorage : MonoBehaviour
{
    //MainMenu Storage

    public InputField playerNameDS;

    public Dropdown wordSpeedDS;

    public void Update()
    {
        Data.Instance.playerName = playerNameDS.text;
        switch (wordSpeedDS.value)
        {
            default:
                Data.Instance.wordSpeed = .5f;
            break;
            case 1:
                Data.Instance.wordSpeed = 1f;
            break;
            case 2:
                Data.Instance.wordSpeed = 1.5f;
            break;
        }
    }
}