using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    public BallSpawner spawner;

    public void OnButtonPress()
    {
        spawner.SpawnBall();
    }
}
