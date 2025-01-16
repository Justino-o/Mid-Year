using UnityEngine;

public class Slot : MonoBehaviour
{
    public int scoreValue;

    private void OnTriggerEnter(Collider other)
    {
        // GameManager.instance.MultiplyScore(scoreValue);
        // Debug.Log(scoreValue);
        GameManager.instance.AddScore(scoreValue);
        
    }   
}
