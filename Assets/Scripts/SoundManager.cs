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
    public static AudioSource effectsScript;
    public static AudioSource musicScript;


    // con esto se llama             SoundManager.PlaySound("BloqueEspecial");

    void Start()
    {
        musicScript = GetComponent<AudioSource>();

        effectsScript = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();

        sonidos[0] = Resources.Load<AudioClip>("PopSound");
        sonidos[1] = Resources.Load<AudioClip>("PopSound2");
        sonidos[2] = Resources.Load<AudioClip>("Pared");

        sonidos[3] = Resources.Load<AudioClip>("Emerge");

        sonidos[4] = Resources.Load<AudioClip>("Colision");
        sonidos[5] = Resources.Load<AudioClip>("muerte");
        sonidos[6] = Resources.Load<AudioClip>("airtone");

        sonidos[7] = Resources.Load<AudioClip>("muerte");

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

            case "otro nombre":
                effectsScript.PlayOneShot(sonidos[2]);
                break;
            case "otro nombre1":
                effectsScript.PlayOneShot(sonidos[3]);
                break;
            case "otro nombre2":
                effectsScript.PlayOneShot(sonidos[4]);
                break;
            case "muerte":
                effectsScript.PlayOneShot(sonidos[5]);
                break;

        }
    }
}
