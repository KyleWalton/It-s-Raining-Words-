using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = 1f;
    //If a random fall speed is required & create a start method that will randomize the fall speed.

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);

        if (transform.position.y < -5)
        {
            if (Data.Instance.playerLives > 0)
            {
                Data.Instance.playerLives--;
                Destroy(gameObject);
            }
            else
            {
                SceneManager.LoadScene("End");
            }
        }
    }
}
