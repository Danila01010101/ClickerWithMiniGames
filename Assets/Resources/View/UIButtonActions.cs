using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonActions : MonoBehaviour
{
    public enum SceneNames { RunnerGame }

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

    public void LoadSceneOnKlick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
