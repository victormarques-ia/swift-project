using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necessário para interagir com UI
using System.Collections.Generic; // Para usar List<>

public class ControllerInputManagerMenu : MonoBehaviour
{
    public List<string> menuOptions = new List<string>(); // Lista de opções do menu
    // a lsita é iniciar, regras e sair

    private int selectedIndex = 0; // Índice da opção selecionada

    void Start()
    {
        menuOptions.Add("start");
        menuOptions.Add("rules");
        menuOptions.Add("exit");
        HighlightOption(selectedIndex); // Destaca a primeira opção ao iniciar
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Down))
        {
            MoveSelection(1); // Move para baixo
        }
        else if (OVRInput.GetDown(OVRInput.Button.Up))
        {
            MoveSelection(-1); // Move para cima
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            SelectOption(); // Seleciona a opção
        }
    }

    private void MoveSelection(int direction)
    {
        selectedIndex += direction;
        if (selectedIndex >= menuOptions.Count)
        {
            selectedIndex = 0; // Volta para o início se passar da última opção
        }
        else if (selectedIndex < 0)
        {
            selectedIndex = menuOptions.Count - 1; // Vai para a última opção se subir acima da primeira
        }

        HighlightOption(selectedIndex);
    }

    private void HighlightOption(int index)
    {
        GameManager.Instance.preButton = menuOptions[index];
    }

    private void SelectOption()
    {
        // Aqui você pode adicionar a lógica para cada opção do menu
        // Exemplo:
        switch (selectedIndex)
        {
            case 0: // Iniciar
                Debug.Log("Iniciar jogo");
                // Adicione aqui a lógica para iniciar o jogo
                GameManager.Instance.selectedButton = "start";
                break;
            case 1: // Regras
                Debug.Log("Mostrar regras");
                GameManager.Instance.selectedButton = "rules";
                // Adicione aqui a lógica para mostrar as regras
                break;
            case 2: // Sair
                Debug.Log("Sair do jogo");
                GameManager.Instance.selectedButton = "exit";
                // Adicione aqui a lógica para sair do jogo
                Application.Quit();
                break;
        }
    }
}
