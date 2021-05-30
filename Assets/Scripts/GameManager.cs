using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        GameObject prefabCanvasWalls = Resources.Load<GameObject>("Prefabs/CanvasWalls");
        GameObject prefabCanvasMainBackground = Resources.Load<GameObject>("Prefabs/CanvasMainBackground");
        Instantiate(prefabCanvasWalls);
        Instantiate(prefabCanvasMainBackground);
    }
}
