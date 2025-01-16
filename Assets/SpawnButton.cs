using UnityEngine;

public class SpawnButton : MonoBehaviour
{
        private GameManager GM;

    public GameObject ballPrefab;
    public Transform spawnPoint;
    public Vector3 spawnRange;
    public void OnButtonPress()
    {
        GM = FindObjectOfType<GameManager>();
        Vector3 randomOffset = new Vector3(
            Random.Range(-spawnRange.x, 2*spawnRange.x),
            Random.Range(-spawnRange.y, 2*spawnRange.y),
            Random.Range(-spawnRange.z, 2*spawnRange.z)
        );
        Vector3 randomSpawnPosition = spawnPoint.position + randomOffset;

        Instantiate(ballPrefab, randomSpawnPosition, Quaternion.identity);
        GM.RemoveScore();
    }
    
}

