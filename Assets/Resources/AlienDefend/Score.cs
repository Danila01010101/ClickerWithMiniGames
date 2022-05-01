using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public int score = 0;

    private void IncreaseScore()
    {
        score++;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    private void OnEnable()
    {
        Bullet.OnEnemyShot += IncreaseScore;
    }

    private void OnDisable()
    {
        Bullet.OnEnemyShot -= IncreaseScore;
    }
}