using System.Collections; // Required for IEnumerator and coroutines
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SlotControls : MonoBehaviour
{
    // Existing variables
    public GameObject[] spinners, colliders;
    public Rigidbody[] reels;
    public bool spinning;
    public Text scoreLabel;
    private bool isSpinning;
    [SerializeField]

    
public Quaternion[] leftSpinnerRots;

    // Start is called before the first frame update
    void Start()
    {
        isSpinning = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Keep logic here if needed
    }

    public void SpinReels()
    {
        MainMan.playerScore -= 25;
        UpdateScoreUI();

        print(MainMan.playerScore);

        if (!isSpinning) // Prevent multiple spins at the same time
        {
            isSpinning = true;
            StartCoroutine(Spinning());
        }
    }
    void UpdateScoreUI()
    {
        Debug.Log($"Sigma");
        if (scoreLabel != null)
        {
            scoreLabel.text = $"Score: ${MainMan.playerScore}";
            Debug.Log($"Updated Score UI: {scoreLabel.text}");
        }
        else
        {
            Debug.LogWarning("ScoreLabel is not assigned in the Inspector.");
        }
    }

    private IEnumerator Spinning()
    {
        // Disable colliders during spinning
        foreach (var collider in colliders)
        {
            collider.SetActive(false);
        }

        // Apply random torque to each reel
        foreach (var reel in reels)
        {
            reel.constraints = RigidbodyConstraints.FreezePositionX |
                               RigidbodyConstraints.FreezePositionY |
                               RigidbodyConstraints.FreezePositionZ |
                               RigidbodyConstraints.FreezeRotationX |
                               RigidbodyConstraints.FreezeRotationY;

            float randTorque = Random.Range(100, 200);
            reel.AddTorque(-randTorque, 0f, 0f, ForceMode.Impulse);
        }

        // Wait for spinning duration
        yield return new WaitForSeconds(5f);

        // Stop reels and re-enable colliders
        foreach (var reel in reels)
        {
            reel.constraints = RigidbodyConstraints.FreezeAll;
        }
        foreach (var collider in colliders)
        {
            collider.SetActive(true);
        }

        // Mark spinning as complete
        isSpinning = false;
    }
}
