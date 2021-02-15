using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fibonacci_Script : MonoBehaviour
{
    public TextMeshProUGUI DisplayRadioFM, Subtitles;
    public GameObject camera1;
    private int X = 1, Y = 1, Z, currentValue, currentValueCamera;
    public string[] PoemSentences;
    public Vector3[] cameraPositions, cameraAngles;
    
    private void Start(){
        DisplayRadioFM.text = "Radio " + X.ToString() + " FM";
        currentValue = 1;
    }
    public void DoMath(){
        Z = X + Y;
        Y = X;
        X = Z;
        DisplayRadioFM.text = "Radio " + Z.ToString() + " FM";
    }

    public void ReadLine(){
        
        if(currentValue >= PoemSentences.Length){
            currentValue = 0;
            Subtitles.text = PoemSentences[1];
        }else{
            Subtitles.text = PoemSentences[currentValue]; 
            currentValue += 1;
        }

        if(currentValueCamera >= cameraPositions.Length){
            currentValueCamera = 0;
        }else{
            camera1.transform.position = cameraPositions[currentValueCamera];
            camera1.transform.eulerAngles = cameraAngles[currentValueCamera];
            currentValueCamera += 1;
        }
        
    }
}
