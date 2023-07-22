using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundType
{
    JUMP,
    DIE
}

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] AudioClip[] audioClip;
    [SerializeField] AudioSource audioSource;

    void Sound(SoundType type)
    {
        audioSource.PlayOneShot(audioClip[(int)type]);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    // Start is called before the first frame update
}
