using UnityEngine;

public class PlinkoScript : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
            Destroy(this.gameObject);
    }
}
