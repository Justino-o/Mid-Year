using UnityEngine;
using UnityEngine.SceneManagement;

public class SlotTP1 : MonoBehaviour
{
    // Method to load a new scene
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}