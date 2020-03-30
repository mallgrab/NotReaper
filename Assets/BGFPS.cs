using UnityEngine;
using UnityEngine.Rendering;

public class BGFPS : MonoBehaviour {
    void OnApplicationFocus(bool hasFocus) {
        if (hasFocus)
        {
            Application.targetFrameRate = Screen.currentResolution.refreshRate;
            OnDemandRendering.renderFrameInterval = 1;
        }
        else
        {
            OnDemandRendering.renderFrameInterval = 5;
        }
    }
}
