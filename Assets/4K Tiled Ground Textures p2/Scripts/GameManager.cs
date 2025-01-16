using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int totalScore;
    public Text scoreLabel;
    
    void Awake()
    {
        if (scoreLabel != null)
        {
            UpdateScoreUI();
        }

        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int score)
    {
        Debug.Log("Score to Add: " + score);
        totalScore += score;
        Debug.Log("Total Score after Addition: " + totalScore);
        UpdateScoreText();
    }

    public void MultiplyScore(int score)
    {
        totalScore*=score;
        Debug.Log(score);
        UpdateScoreText();
    }

    
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + totalScore;
    }
}
