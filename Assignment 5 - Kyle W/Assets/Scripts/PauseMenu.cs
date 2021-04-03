using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //public bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Data.Instance.gameIsPaused)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }
    }

    public void GameResume()
    {
        pauseMenuUI.SetActive(false);
        Data.Instance.wordSpeed = Data.Instance.speed;
        Data.Instance.gameIsPaused = false;
    }

    void GamePause()
    {
        pauseMenuUI.SetActive(true);
        Data.Instance.speed = Data.Instance.wordSpeed;
        Data.Instance.wordSpeed = 0f;
        Data.Instance.gameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Data.Instance.score = 0;
    }


}
