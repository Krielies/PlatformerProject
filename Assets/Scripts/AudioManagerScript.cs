using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioClip Footstep_, Jump_, Landing_, Gonna_;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        Footstep_ = Resources.Load<AudioClip>("Walking");
        Jump_ = Resources.Load<AudioClip>("Jump");
        Gonna_= Resources.Load<AudioClip>("Never");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        if (clip == "Footstep" && !audioSrc.isPlaying)
        {
            audioSrc.pitch = 0.89F;
                audioSrc.PlayOneShot(Footstep_);
        }else if (clip == "Jump")
        {
            audioSrc.PlayOneShot(Jump_);
        }
    }
}
