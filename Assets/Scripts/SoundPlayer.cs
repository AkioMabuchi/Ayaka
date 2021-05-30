using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public enum SoundName
{
    Test
}

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private GameObject prefabSound;

    private SoundPlayerModel _soundPlayerModel;

    private readonly Dictionary<SoundName, AudioClip> _audioClips = new Dictionary<SoundName, AudioClip>();
    private void Awake()
    {
        _soundPlayerModel = ModelBank.SoundPlayerM;
        _audioClips.Add(SoundName.Test, null);
    }

    private void Start()
    {
        _soundPlayerModel.ObservableSoundName.Subscribe(PlaySound);
    }

    void PlaySound(SoundName soundName)
    {
        Instantiate(prefabSound).GetComponent<Sound>().Initialize(_audioClips[soundName]);
    }
}
