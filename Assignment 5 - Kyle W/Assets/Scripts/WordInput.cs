using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager wordManager;

    void Update()
    {
        if (!Data.Instance.gameIsPaused)
        {
            foreach (char letter in Input.inputString)
            {
                wordManager.TypeLetter(letter);
            }
        }
    }
}
