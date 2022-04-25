using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;

    private void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("AlienDefend");
        Time.timeScale = 1f;
    }

    public void ExitToMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    private void OnEnable()
    {
        Cart.GameOver += ShowGameOverScreen;
    }

    private void OnDisable()
    {
        Cart.GameOver -= ShowGameOverScreen;
    }
}