using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class FortuneWheelManager : MonoBehaviour
{
    public FortuneWheel fortuneWheel;
    public Text resultLabel;       // Displays the wheel result
    public Text scoreLabel;        // Displays the player's score

    // Global variable to track the score
    

    void Awake()
    {
        StartCoroutine(AddScoreEvery10Seconds());
        // Initialize the score label if not null
        if (scoreLabel != null)
        {
            UpdateScoreUI();
        }
    }
    IEnumerator AddScoreEvery10Seconds()
    {
        while (true) // Infinite loop to keep adding to the score
        {
            yield return new WaitForSeconds(10f); // Wait for 10 seconds
            MainMan.playerScore += 25;
            Debug.Log($"Player Score: {MainMan.playerScore}");
            UpdateScoreUI();
        }
    }

    public void Spin()
    {
        MainMan.playerScore -= 50;
        UpdateScoreUI();
        print(MainMan.playerScore);
        StartCoroutine(SpinCoroutine());
    }

    IEnumerator SpinCoroutine()
    {
        yield return StartCoroutine(fortuneWheel.StartFortune());

        if (resultLabel == null) yield break;

        string result = fortuneWheel.GetLatestResult();
        resultLabel.text = result;

        // Update the score based on the result
        UpdateScore(result);

        print($"Result: {result}");
        print($"Player Score: {MainMan.playerScore}");
    }

    void UpdateScore(string result)
    {

        // Parse the result to an integer
        if (int.TryParse(result, out int wheelValue))
        {
            switch (wheelValue)
            {
                case 1:
                    MainMan.playerScore /= 2; // Halve the player score
                    break;
                case 2:
                    MainMan.playerScore += 200; // Add 200 to the player score
                    break;
                case 3:
                    MainMan.playerScore -= 200; // Subtract 200 from the player score
                    break;
                    case 4:
                    MainMan.playerScore += 50;
                    break;
                case 5:
                    MainMan.playerScore *= 2; // Double the player score
                    break;
                default:
                    Debug.LogWarning($"Unexpected wheel value: {wheelValue}");
                    break;
            }

            // Update the score UI
            UpdateScoreUI();
        }
        else
        {
            Debug.LogWarning("Result is not a valid number!");
        }
    }

    void UpdateScoreUI()
    {
        Debug.Log($"Sigma");
        if (scoreLabel != null)
        {
            scoreLabel.text = $"Score: ${MainMan.playerScore}";
            Debug.Log($"Updated Score UI: {scoreLabel.text}");
        }
        else
        {
            Debug.LogWarning("ScoreLabel is not assigned in the Inspector.");
        }
    }

}
