using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{


    public int ScoreGain;
    public int TimeGain;

    public GameController GC;


    private void OnTriggerStay(Collider other) 
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("key pressed");
            GC.AddScore(ScoreGain,TimeGain);

            //add cooldown or usce gamecontroller for cooldown
        }
    }




}
