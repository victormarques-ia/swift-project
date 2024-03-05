using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class asdasd : MonoBehaviour
{
    public Transform cubeTransform; // Atribua o Transform do seu cubo aqui no inspector do Unity
    private InputDevice rightController;

    void Start()
    {
        // Inicializa o controle direito
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller, devices);
         Debug.Log("Devices: " + devices.Count);
        if (devices.Count > 0)
        {
            rightController = devices[0];
        }
    }

    void Update()
    {
        if (rightController.isValid)
        {
            Vector3 rightControllerPosition;
            // Pega a posição do controle direito
            Debug.Log("Right Controller Position: " + CommonUsages.devicePosition);
            if (rightController.TryGetFeatureValue(CommonUsages.devicePosition, out rightControllerPosition))
            {
                // qDebug.Log("Right Controller Position: " + rightControllerPosition);
                cubeTransform.position = rightControllerPosition;
            }
        }
    }
}
