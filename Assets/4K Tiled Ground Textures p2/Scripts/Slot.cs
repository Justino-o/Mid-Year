using UnityEngine;

public class Slot : MonoBehaviour
{
    public int scoreValue = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlinkoBall"))
        {
            GameManager.instance.AddScore(scoreValue);
            Destroy(other.gameObject);
        }
    }
}