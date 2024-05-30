using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioMixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    [SerializeField] private Slider MusicMasTerSlider;
    [SerializeField] private Slider MusicBGMSlider;
    [SerializeField] private Slider MusicSFXSlider;

    private void Awake()
    {
        MusicMasTerSlider.onValueChanged.AddListener(SetMasterVolume);
        MusicBGMSlider.onValueChanged.AddListener(SetBGMVolume);
        MusicSFXSlider.onValueChanged.AddListener(SetSFXVolume);
    }

    private void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
    }
    private void SetBGMVolume(float volume)
    {
        audioMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
    }
    private void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
}
