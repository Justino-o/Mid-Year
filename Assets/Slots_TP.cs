using UnityEngine;
using UnityEngine.SceneManagement;

public class Slots_TP : MonoBehaviour
{
    // Method to load a new scene
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}