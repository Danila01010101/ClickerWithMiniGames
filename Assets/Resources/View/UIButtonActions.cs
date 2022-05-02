using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonActions : MonoBehaviour
{
    [SerializeField] private GameObject _endGameScreen;

    public void SetActiveOnKlick(GameObject gameObject)
    {
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void SetActiveOnEndGame()
    {
        if (_endGameScreen != null)
        {
            _endGameScreen.SetActive(true);
        }
    }

    public void LoadSceneOnKlick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnEnable()
    {
        EndGameTrigger.OnGameOver += SetActiveOnEndGame;
    }

    private void OnDisable()
    {
        EndGameTrigger.OnGameOver -= SetActiveOnEndGame;
    }
}
