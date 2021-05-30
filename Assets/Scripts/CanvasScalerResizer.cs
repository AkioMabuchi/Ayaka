using UnityEngine;
using UnityEngine.UI;

public class CanvasScalerResizer : MonoBehaviour
{
    private CanvasScaler _canvasScaler;
    private void Awake()
    {
        _canvasScaler = GetComponent<CanvasScaler>();
    }

    private void Start()
    {
        _canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        _canvasScaler.referenceResolution = new Vector2(1920.0f, 1080.0f);
        _canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        _canvasScaler.matchWidthOrHeight = Screen.width * 9 / Screen.height >= 16 ? 1.0f : 0.0f;
    }

    private void Update()
    {
        _canvasScaler.matchWidthOrHeight = Screen.width * 9 / Screen.height >= 16 ? 1.0f : 0.0f;
    }
}
