using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necessário para interagir com UI
using System.Collections.Generic; // Para usar List<>
public class ControllerInputManagerEras : MonoBehaviour
{
    private int selectedIndex = 0;
    private int rows = 2;
    private int cols = 5;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Right))
        {
            if ((selectedIndex + 1) % cols != 0)
            {
                selectedIndex++;
                HighlightOption(selectedIndex);
            }
        }

        else if (OVRInput.GetDown(OVRInput.Button.Left))
        {
            if (selectedIndex % cols != 0)
            {
                selectedIndex--;
                HighlightOption(selectedIndex);
            }
        }

        else if (OVRInput.GetDown(OVRInput.Button.Down))
        {
            if (selectedIndex + cols < rows * cols)
            {
                selectedIndex += cols;
                HighlightOption(selectedIndex);
            }
        }

        else if (OVRInput.GetDown(OVRInput.Button.Up))
        {
            if (selectedIndex - cols >= 0)
            {
                selectedIndex -= cols;
                HighlightOption(selectedIndex);
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            SelectOption(selectedIndex);
        }
    }

    private void HighlightOption(int index)
    {
        Debug.Log("Opção selecionada: " + index);
        GameManager.Instance.preButton = "eras" + index;
    }

    private void SelectOption(int index)
    {
        Debug.Log("Selecionou a opção do grid com índice: " + index);
        GameManager.Instance.selectedButton = "eras" + index;
    }
}
