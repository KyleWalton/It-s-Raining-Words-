using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Data : MonoBehaviour
{
    //Stores data and persists
    public static Data Instance { get; private set; }

    public string playerName;

    public float wordSpeed;

    public int score = 0;

    public int playerLives;

    public bool gameIsPaused;

    public float speed;

    private void Update()
    {
        Time.timeScale = wordSpeed;
    }

    private void Start()
    {
        playerLives = 3;
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
