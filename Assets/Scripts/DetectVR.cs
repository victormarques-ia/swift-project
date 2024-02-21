using UnityEngine;
using UnityEngine.XR.Management;

// Source: https://gist.github.com/demonixis/fc2f9154cd9d87e5f1c6a7a1de2dbb70
public class DetectVR : MonoBehaviour
{
    public bool startInVR = true;
    public GameObject xrOrigin;
    public GameObject desktopCharacter;
    
    void Start()
    {
        if (startInVR)
        {        
            var xrSettings = XRGeneralSettings.Instance;
            if (xrSettings == null)
            {
                Debug.Log("XRGeneralSettings is null");
                return;
            }
        
            var xrManager = xrSettings.Manager;
            if (xrManager == null)
            {
                Debug.Log("XRManagerSettings is null");
                return;
            }
        
            var xrLoader = xrManager.activeLoader;
            if (xrLoader == null)
            {
                Debug.Log("XRLoader is null");
                xrOrigin.SetActive(false);
                desktopCharacter.SetActive(true);
                return;
            }
        
            Debug.Log("XRLoader is NOT null");
            xrOrigin.SetActive(true);
            desktopCharacter.SetActive(false);
        }
        else
        {
            xrOrigin.SetActive(false);
            desktopCharacter.SetActive(true);
        }
    }
}
