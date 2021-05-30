using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class ModelBank
{
    public static SoundPlayerModel SoundPlayerM;
    [RuntimeInitializeOnLoadMethod] 
    private static void GenerateModels()
    {
        SoundPlayerM = new SoundPlayerModel();
        Debug.Log("ModelBank");
    }
}
