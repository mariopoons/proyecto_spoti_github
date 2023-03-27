using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] songs;

    public int currentSong;

    private AudioSource _audioSource;

    public TextMeshProUGUI songText;

    public Button playButton, pauseButton;

    // buenos dias, se esta despertando audosource!
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // esto hace play y suena
    public void PlaySong()
    {
        _audioSource.clip = songs[currentSong];    
        _audioSource.Play();
        songText.text = songs[currentSong].name;

    }

    public void PreviousSong()
    {
        currentSong--;
        if( currentSong<0)
        {
            currentSong = songs.Length - 1;
        }
        PlaySong();
    }

    public void NextSong()
    {
        currentSong++;
        if (currentSong >= songs.Length)
        {
            currentSong = 0;
        }
        PlaySong();
    }

    public void RandomSong()
    {
        currentSong = Random.Range(0, songs.Length);
        PlaySong();
    }

    public void PlayButtonFuntion()
    {
        playButton.interactable = false;
        pauseButton.interactable = true;
    }
    public void PauseButtonFuntion()
    {
        playButton.interactable = true;
        pauseButton.interactable = false;
    }

    public void PlayPauseButtonFuntion(bool playButtonHasBeenPressed)
    {
        playButton.interactable = !playButtonHasBeenPressed; // false
        pauseButton.interactable = playButtonHasBeenPressed; // ture
    }
}
