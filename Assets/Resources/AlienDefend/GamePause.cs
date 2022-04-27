using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    [SerializeField] private GameObject gamePauseScreen;
    [SerializeField] private GameObject gameBar;

    private static bool GameIsPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (GameIsPaused)
            {
                gamePauseScreen.SetActive(false);
                gameBar.SetActive(true);
                Time.timeScale = 1f;
                GameIsPaused = false;
            }
            else
            {
                gamePauseScreen.SetActive(true);
                gameBar.SetActive(false);
                Time.timeScale = 0f;
                GameIsPaused = true;
            }
        }
    }
}

