using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("audio source")]
    [SerializeField] private AudioSource bgm;
    [SerializeField] private AudioSource player_1_source, player_2_source, effect_source;
    [Header("audio clip")]
    [SerializeField] private AudioClip backGround;
    [SerializeField] private AudioClip swimming_1, swimming_2, swimming_3, hitted, earnPoint, player_swimming_1, player_Swimming_2;
    void Start()
    {
        playSound(backGround, "bgm");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSound(AudioClip au, string source)
    {
        switch(source)
        {
            case "player_1":
            case "Player_1":
            case "player1":
            case "Player1":
                player_1_source.clip = au;
                player_1_source.loop = false;
                player_1_source.Play();
                break;

            case "player_2":
            case "Player_2":
            case "player2":
            case "Player2":
                player_2_source.clip = au;
                player_2_source.loop = false;
                player_2_source.Play();
                break;

            case "effect_source":
            case "Effect_source":
            case "effectSource":
            case "effect":
                effect_source.clip = au;
                effect_source.loop = false;
                effect_source.Play();
                break;

            case "bgm":
                bgm.clip = au;
                bgm.loop = true;
                bgm.Play();
                break;
        }
    }
    public void playSound(AudioClip au, string source, float volume)
    {
        switch (source)
        {
            case "player_1":
            case "Player_1":
            case "player1":
            case "Player1":
                player_1_source.clip = au;
                player_1_source.loop = false;
                player_1_source.volume = volume;
                player_1_source.Play();
                break;

            case "player_2":
            case "Player_2":
            case "player2":
            case "Player2":
                player_2_source.clip = au;
                player_2_source.loop = false;
                player_2_source.volume = volume;
                player_2_source.Play();
                break;

            case "effect_source":
            case "Effect_source":
            case "effectSource":
            case "effect":
                effect_source.clip = au;
                effect_source.loop = false;
                effect_source.volume = volume;
                effect_source.Play();
                break;

            case "bgm":
                bgm.clip = au;
                bgm.loop = true;
                bgm.volume = volume;
                bgm.Play();
                break;
        }
    }

    public AudioClip getClip(string clipName)
    {
        switch(clipName)
        {
            case "swim1":
                return swimming_1;

            case "swim2":
                return swimming_2;

            case "swim3":
                return swimming_3;

            case "hitted":
                return hitted;

            case "player1":
                return player_swimming_1;

            case "player2":
                return player_Swimming_2;

            case "point":
                return earnPoint;

        }

        return null;
    }

    public bool isPlaying(string sourceName)
    {
        switch(sourceName)
        {
            case "player1":
            case "player_1":
                return player_1_source.isPlaying;
            case "player2":
            case "player_2":
                return player_2_source.isPlaying;
            case "effect":
                return effect_source.isPlaying;
        }

        return false ;
    }

    public void stopPlaySound(string sourceName)
    {
        switch(sourceName)
        {
            case "player_1":
            case "player1":
                player_1_source.Stop();
                break;

            case "player_2":
            case "player2":
                player_2_source.Stop();
                break;

            case "effect_source":
            case "effect":
                effect_source.Stop();
                break;
        }
    }
}
