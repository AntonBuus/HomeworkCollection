using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Whip : MonoBehaviour
{
    public AudioClip clip;
    public float thresh = 3;
    public TMPro.TMP_Text text;
    private bool trigger = false;

    void Update()
    {
        if (Input.acceleration.magnitude > thresh) {
            if (!trigger) {
                trigger = true;
                GetComponent<AudioSource>().PlayOneShot(clip);
            }
        } else if (trigger) {
            trigger = false;
        }
        if(text)
            text.text = "Acceleration " + Input.acceleration.ToString();
    }
}
