using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SlotControls: MonoBehaviour
{
    private ScoreCalculator tsc;
    private AudioControls tac;
    private ScoreCalculator tscal;

    public GameObject[] spinners,colliders;
    public Rigidbody[]reels;
    public bool startBool, playGame, spinning, bonusBool, featureBool;
    [SerializeField]
    public Quaternion[] leftSpinnerRots;
    public int quaternionZInt;
    void Start(){
        tscal=FindObjectOfType<ScoreCalculator>();
        // for(int i=0; i<leftSpinnerRots.Length;i++){
        //     if(i==0){
        //         leftSpinnerRots[0]=Quaternion.Euler(reels[0].transform.eulerAngles.x,reels[0].transform.eulerAngles.y,reels[0].transform.eulerAngles.z);
        //     }
        //     else{
        //         quaternionZInt+=24;
        //          leftSpinnerRots[i]=Quaternion.Euler(reels[0].transform.eulerAngles.x,reels[0].transform.eulerAngles.y,reels[0].transform.eulerAngles.z-quaternionZInt);
        //     }
        // }
    }
    void Update(){
        if(spinning){
            spinning=false;
            // for(int i=0; i<reels.Length;i++){
            //     reels[i].constraints=RigidbodyConstraints.FreezeAll;
            // }
            StartCoroutine(Spinning());
        }
    }
    IEnumerator Spinning(){
        for(int i=0;i<colliders.Length; i++){
            colliders[i].SetActive(false);
        }
        for(int i=0;i<reels.Length;i++){
            reels[i].constraints=RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezePositionY |RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY;
            float randTorque=Random.Range(100,200);
            Debug.Log(randTorque);
            reels[i].AddTorque(-randTorque,0f,0f,ForceMode.Impulse);

        }  
        yield return new WaitForSeconds(5f);
        tscal.lReelCalScoresBool=false;
        Debug.Log("Stop Spinning");
        for(int i=0; i<reels.Length;i++){
            reels[i].constraints=RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezePositionY |RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
        }
            yield return new WaitForSeconds(.3f);
        for(int i=0;i<colliders.Length; i++){
            colliders[i].SetActive(true);
        }
        yield return new WaitForSeconds(5f);
        // spinning=true;
    }

}
