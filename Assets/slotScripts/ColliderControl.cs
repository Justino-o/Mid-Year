using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderControl : MonoBehaviour
{
    private SlotControls tsc;
    private ScoreCalculator tscal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other){
        tsc = FindObjectOfType<SlotControls>();
        tscal=FindObjectOfType<ScoreCalculator>();
        if(!tscal.lReelCalScoresBool){
            tscal.lReelCalScoresBool=true;
            switch(other.gameObject.tag){
                case "red7_1":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[2];
                    tscal.ColScores[0]="red7";
                    break;
                case "red7_2":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[14];
                    tscal.ColScores[0]="red7";
                    break;
                case "red7_3":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[10];
                    tscal.ColScores[0]="red7";
                    break;
                case "red7_4":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[5];
                    tscal.ColScores[0]="red7";
                    break;
                case "green7_1":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[0];
                    tscal.ColScores[0]="green7";
                    break;
                case "green7_2":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[12];
                    tscal.ColScores[0]="green7";
                    break;
                case "green7_3":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[8];
                    tscal.ColScores[0]="green7";
                    break;
                case "green7_4":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[4];
                    tscal.ColScores[0]="green7";
                    break;
                case "redhot_1":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[1];
                    tscal.ColScores[0]="redhot";
                    break;
                case "redhot_2":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[13];
                    tscal.ColScores[0]="redhot";
                    break;
                case "redhot_3":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[6];
                    tscal.ColScores[0]="redhot";
                    break;
                case "doubleRH_1":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[11];
                    tscal.ColScores[0]="doubleRH";
                    break;
                case "doubleRH_2":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[3];
                    tscal.ColScores[0]="doubleRH";
                    break;
                case "tripleRH_1":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[9];
                    tscal.ColScores[0]="tripleRH";
                    break;
                case "bonus_1":
                    tsc.reels[0].transform.rotation=tsc.leftSpinnerRots[7];
                    tscal.ColScores[0]="bonus";
                    break;
            }
            Debug.Log(other.gameObject.tag);
        }
    }
}
