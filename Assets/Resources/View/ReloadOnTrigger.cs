using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
