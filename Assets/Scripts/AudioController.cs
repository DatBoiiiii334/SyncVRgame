using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private static AudioClip RadioSwitch, AudioClip1, AudioClip2;
    private static AudioSource audioSource;

    public void Start(){
        RadioSwitch = Resources.Load<AudioClip>("RadioSwitch");
        AudioClip1 = Resources.Load<AudioClip>("");
        AudioClip2 = Resources.Load<AudioClip>("");
        audioSource = GetComponent<AudioSource>();
    }


}
