using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class LightEstimationApplier : MonoBehaviour
{
    [SerializeField]
    private ARCameraManager cameraManager;

    private Light directionalLight;

    void Awake()
    {
        directionalLight = GetComponent<Light>();
    }

    void OnEnable()
    {
        if (cameraManager != null)
            cameraManager.frameReceived += OnCameraFrameReceived;
    }

    void OnDisable()
    {
        if (cameraManager != null)
            cameraManager.frameReceived -= OnCameraFrameReceived;
    }

    void OnCameraFrameReceived(ARCameraFrameEventArgs args)
    {
        if (args.lightEstimation.averageBrightness.HasValue)
        {
            directionalLight.intensity = args.lightEstimation.averageBrightness.Value;
        }

        if (args.lightEstimation.averageColorTemperature.HasValue)
        {
            directionalLight.colorTemperature = args.lightEstimation.averageColorTemperature.Value;
        }
    }
}