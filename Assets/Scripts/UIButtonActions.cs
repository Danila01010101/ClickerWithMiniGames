using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonActions : MonoBehaviour
{
    public enum SceneNames { RunnerGame }

    public void SetActiveOnKlick(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void LoadSceneOnKlick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
