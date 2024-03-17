using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necessário para interagir com UI
using System.Collections.Generic; // Para usar List<>
public class ControllerInputManagerRules : MonoBehaviour
{
    public List<string> menuOptions = new List<string>();


    private int selectedIndex = 0;

    void Start()
    {
        menuOptions.Add("back-rules");
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
                GameManager.Instance.selectedButton = "back-rules";
                break;

    }
    }
}