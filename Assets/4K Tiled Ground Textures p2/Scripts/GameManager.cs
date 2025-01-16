using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

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
        MainMan.playerScore += score;
        Debug.Log("Total Score after Addition: " + MainMan.playerScore);
        UpdateScoreUI();
    }


    
    private void UpdateScoreUI()
    {
        {
        Debug.Log($"Sigma");
        if (scoreLabel != null)
        {
            scoreLabel.text = $"Score: {MainMan.playerScore}";
            Debug.Log($"Updated Score UI: {scoreLabel.text}");
        }
        else
        {
            Debug.LogWarning("ScoreLabel is not assigned in the Inspector.");
        }
    }
    }
}
