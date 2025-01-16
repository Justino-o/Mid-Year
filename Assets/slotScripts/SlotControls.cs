using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SlotControls: MonoBehaviour
{
    private ScoreCalculator tsc;
    private AudioControls tac;
    public GameObject[] spinners,colliders;
    public Rigidbody[]reels;
    public bool startBool, playGame, spinning, bonusBool, featureBool;
    void Start(){
 
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
        // for(int i=0;i<colliders.Length; i++){
        //     colliders[i].SetActive(false);
        // }
        for(int i=0;i<reels.Length;i++){
            reels[i].constraints=RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezePositionY |RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY;
            int randTorque=Random.Range(100,200);
            Debug.Log(randTorque);
            reels[i].AddTorque(-randTorque,0f,0f,ForceMode.Impulse);

        }  
        yield return new WaitForSeconds(8f);
        Debug.Log("Stop Spinning");
        for(int i=0; i<reels.Length;i++){
            reels[i].constraints=RigidbodyConstraints.FreezeRotationZ;
        }
        yield return new WaitForSeconds(5f);
        spinning=true;
    }
}
