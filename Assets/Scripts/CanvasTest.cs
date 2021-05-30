using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class CanvasTest : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProScreenSize;

    private SoundPlayerModel _soundPlayerModel;

    private void Awake()
    {
        _soundPlayerModel = ModelBank.SoundPlayerM;
    }

    private void Start()
    {
        this.UpdateAsObservable()
            .Subscribe(_ =>
            {
                textMeshProScreenSize.text = "X:" + Screen.width + " Y:" + Screen.height;
            });

        this.UpdateAsObservable()
            .Where(_ => Input.GetKeyDown(KeyCode.Space))
            .Subscribe(_ =>
            {
                _soundPlayerModel.PlaySound(SoundName.Test);
            });
    }
}
