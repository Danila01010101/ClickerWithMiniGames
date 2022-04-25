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
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("AlienDefend");
    }

    public void ExitToMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
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