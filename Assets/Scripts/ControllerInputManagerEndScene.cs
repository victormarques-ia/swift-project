using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInputManagerEndScene : MonoBehaviour
{
    public List<string> menuOptions = new List<string>();


    private int selectedIndex = 0;

    void Start()
    {
        menuOptions.Add("restart");
        menuOptions.Add("exit");
        HighlightOption(selectedIndex); 
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Down))
        {
            MoveSelection(1);
        }
        else if (OVRInput.GetDown(OVRInput.Button.Up))
        {
            MoveSelection(-1);
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            SelectOption(); 
        }
    }

    private void MoveSelection(int direction)
    {
        selectedIndex += direction;
        if (selectedIndex >= menuOptions.Count)
        {
            selectedIndex = 0; 
        }
        else if (selectedIndex < 0)
        {
            selectedIndex = menuOptions.Count - 1;
        }

        HighlightOption(selectedIndex);
    }

    private void HighlightOption(int index)
    {
        GameManager.Instance.preButton = menuOptions[index];
    }

    private void SelectOption()
    {

        switch (selectedIndex)
        {
            case 0:
                Debug.Log("Iniciar jogo");

                GameManager.Instance.selectedButton = "restart";
                break;
            case 1:
                Debug.Log("Sair do jogo");
                GameManager.Instance.selectedButton = "exit";

                Application.Quit();
                break;
        }
    }
}
