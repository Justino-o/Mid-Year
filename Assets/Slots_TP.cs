using UnityEngine;
using UnityEngine.SceneManagement;

public class Slots_TP : MonoBehaviour
{
    // Method to load a new scene
    void OnTriggerEnter(Collider other)
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("SlotMachine");
    }
}