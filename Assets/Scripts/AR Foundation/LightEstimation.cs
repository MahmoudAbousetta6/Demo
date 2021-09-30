using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class LightEstimation : MonoBehaviour
{
    [SerializeField]
    private ARCameraManager arCameraManager;

    private Light currentLight;

    private void Awake() 
    {
        currentLight = GetComponent<Light>();
    }

    private void OnEnable() 
    {
        arCameraManager.frameReceived += FrameUpdated;
    }

    private void OnDisable() 
    {
        arCameraManager.frameReceived -= FrameUpdated;
    }

    private void FrameUpdated(ARCameraFrameEventArgs args)
    {
        if(args.lightEstimation.averageBrightness.HasValue)
            currentLight.intensity = args.lightEstimation.averageBrightness.Value;

        if(args.lightEstimation.averageColorTemperature.HasValue)
            currentLight.colorTemperature = args.lightEstimation.averageColorTemperature.Value;

        if(args.lightEstimation.colorCorrection.HasValue)
            currentLight.color = args.lightEstimation.colorCorrection.Value;
    }
}
