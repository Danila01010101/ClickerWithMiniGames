using UnityEngine;

public class ControlScreen : MonoBehaviour
{
    [SerializeField] private GameObject controlScreen;
    [SerializeField] private GameObject healthBar;

    private static bool GameIsPaused = true;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                controlScreen.SetActive(false);
                healthBar.SetActive(true);
                Time.timeScale = 1f;
                GameIsPaused = true;
            }
            else
            {
                controlScreen.SetActive(true);
                healthBar.SetActive(false);
                Time.timeScale = 0f;
                GameIsPaused = false;
            }
        }
    }
}
