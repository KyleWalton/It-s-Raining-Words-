using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
public class SystemController : MonoBehaviour
{
    public void CreateSave()
    {
        SaveGame();
    }

    public AudioSource music;

    private Save CreateSaveGameObject()
    {
        Save save = new Save();

        save.sName = Data.Instance.playerName;
        save.sScore = Data.Instance.score;
        save.sLives = Data.Instance.playerLives;
        save.sWordSpeed = Data.Instance.speed;


        return save;
    }

    public void SaveGame()
    {
        Save save = CreateSaveGameObject();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
        Debug.Log("Game Saved");
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            SceneManager.LoadScene("Game");

            Data.Instance.playerName = save.sName;
            Data.Instance.score = save.sScore;
            Data.Instance.playerLives = save.sLives;
            Data.Instance.wordSpeed = save.sWordSpeed;

            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }

    public void toggleMusic()
    {
        if (music.mute)
        {
            music.mute = false;
        }
        else
        {
            music.mute = true;
        }
    }
}
