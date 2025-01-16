using UnityEngine;

public class MainMan : MonoBehaviour
{
    //public Text score;
    public static int playerScore = 100;

    void Start()
    {
        Debug.Log(playerScore); // Logs the player's score when the game starts.
    }
}
