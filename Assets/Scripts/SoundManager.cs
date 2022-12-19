using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("no se destruyo en load el musica");

        }
        else
        {
            print("se destruyo musicObject");
            Destroy(gameObject);
        }

    }

    public static AudioClip[] sonidos;
    public static AudioClip sadas;
    public static AudioSource effectsScript;
    public static AudioSource musicScript;


    // con esto se llama             SoundManager.PlaySound("BloqueEspecial");

    void Start()
    {
        musicScript = GetComponent<AudioSource>();

       // effectsScript = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();


      sadas = Resources.Load<AudioClip>("Ataques");
        sonidos[1] = Resources.Load<AudioClip>("Spawn");
        sonidos[2] = Resources.Load<AudioClip>("Minando");
        sonidos[3] = Resources.Load<AudioClip>("Muerte");

        print("iNICIO START DE MUSICA");
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "golpe":
                effectsScript.PlayOneShot(sonidos[0]);
                break;
            case "spawn":
                effectsScript.PlayOneShot(sonidos[1]);
                break;
            case "minando":
                effectsScript.PlayOneShot(sonidos[2]);
                break;
            case "muerte":
                effectsScript.PlayOneShot(sonidos[2]);
                break;

        }
    }
}
