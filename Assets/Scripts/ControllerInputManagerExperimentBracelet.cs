using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInputManagerExperimentBracelet : MonoBehaviour
{
    public List<string> menuOptions = new List<string>();


    private int selectedIndex = 0;

    void Start()
    {
        menuOptions.Add("goToEnd");
        HighlightOption(selectedIndex);
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            SelectOption();
        }
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
                Debug.Log("Voltar menu");
                GameManager.Instance.selectedButton = "goToEnd";
                break;

    }
    }
}
