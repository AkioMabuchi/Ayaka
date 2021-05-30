using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class SoundPlayerModel
{
    private readonly Subject<SoundName> _subjectSoundName = new Subject<SoundName>();
    public IObservable<SoundName> ObservableSoundName => _subjectSoundName;
    
    public void PlaySound(SoundName soundName)
    {
        _subjectSoundName.OnNext(soundName);
    }
}
