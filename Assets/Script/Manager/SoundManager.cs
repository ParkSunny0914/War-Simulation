using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance;

    public AudioSource audioSource;

    [SerializeField] AudioClip[] audioClip;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void Sound(int number)
    {
        audioSource.PlayOneShot(audioClip[number]);
    }
}
