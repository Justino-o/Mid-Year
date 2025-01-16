using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    private SlotControls tsc;
    public string[]ColScores;
    public bool lReelCalScoresBool;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tsc = FindObjectOfType<SlotControls>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
