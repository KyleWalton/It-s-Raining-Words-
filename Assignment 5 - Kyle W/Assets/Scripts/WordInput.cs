using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager wordManager;

    void Update()
    {
        //InputString - Shows all the characters that the player has typed.
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
            //Debug.Log(letter);
        }
    }
}
