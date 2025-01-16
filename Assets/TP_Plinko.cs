using UnityEngine;
using UnityEngine.SceneManagement;

public class TP_Plinko : MonoBehaviour
{
    // Method to load a new scene
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
