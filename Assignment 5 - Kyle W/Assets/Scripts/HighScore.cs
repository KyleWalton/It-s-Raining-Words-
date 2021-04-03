using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static string path = "./highscores.txt";
    public Text HighscoresList;

    public ArrayList Highscores = new ArrayList();

    public void Start()
    {
        writeScore();
        readScores();
        sort();
        displayScores();
    }

    public void writeScore()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(("\n" + Data.Instance.score + " " + Data.Instance.playerName));
        writer.Close();
    }

    public void readScores()
    {
        StreamReader reader = new StreamReader(path);

        while (reader.Peek() > 0)
        {
            Highscores.Add(reader.ReadLine());
        }
        reader.Close();
    }

    public void displayScores()
    {
        for (int i = 0; i < Highscores.Count; i++)
        {
            if (Highscores[i].ToString() != "")
            {
                HighscoresList.text += i + 1 + ". " + Highscores[i] + "\n";
            }

        }
    }

    public void sort()
    {
        Highscores.Sort();
        Highscores.Reverse();

    }
    public void clearHighScores()
    {
        Highscores.Clear();
        HighscoresList.text = "";
        File.WriteAllText(path, string.Empty);
    }
}