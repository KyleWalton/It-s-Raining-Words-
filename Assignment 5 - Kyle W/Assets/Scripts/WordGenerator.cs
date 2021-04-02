using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    //For anyone wondering how you would load words from a text file, it's quite simple. 
    //    Instead of hardcoding the wordList array, in the GetRandomWord() method you add this line
    //    wordList = File.ReadAllLines("Assets/WordLists/wordList.txt"); (obviously change to where youre storing your wordlist)

    private static string[] wordList =
    {
        "sidewalk", "robin", "three", "protect", "periodic",
        "somber", "majestic", "jump", "pretty", "wound", "jazzy",
        "memory", "join", "crack", "grade", "boot", "cloudy", "sick",
        "mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
        "weird", "cut", "parallel", "wood", "encouraging", "interrupt",
        "guide", "long", "chief", "mom", "signal", "rely", "abortive",
        "hair", "representative", "earth", "grate", "proud", "feel",
        "hilarious", "addition", "silent", "play", "floor", "numerous",
        "friend", "pizzas", "building", "organic", "past", "mute", "unusual",
        "mellow", "analysis", "crate", "homely", "protest", "painstaking",
        "society", "head", "female", "eager", "heap", "dramatic", "present",
        "sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
        "boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "scarce",
        "account", "spot", "thought", "distinct", "nimble", "practice", "cream",
        "ablaze", "thoughtless", "love", "verdict", "giant", "dab"
    };

	public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
