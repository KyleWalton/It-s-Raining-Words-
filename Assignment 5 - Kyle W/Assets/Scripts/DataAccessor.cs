using UnityEngine;
using UnityEngine.UI;

public class DataAccessor : MonoBehaviour
{
    //Allows you to access the Data Instance for Game and End scenes.

    public Text playerName;

    public Text score;

    public Text playerLives;

    public Text wordSpeed;



    // Update is called once per frame
    void Update()
    {
        //playerName.text = "" + Data.Instance.playerName;
        score.text = Data.Instance.score.ToString();
        playerLives.text = "Lives: " + Data.Instance.playerLives;

    }
}
