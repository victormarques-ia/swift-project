using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necessário para acessar a classe Button
public class ButtonSelected : MonoBehaviour
{
    string tag;
    Button button;
    Image imageComponent;
    void Start()
    {
        button = GetComponent<Button>();
        imageComponent = GetComponent<Image>();
        tag = this.gameObject.tag; // Agora a propriedade tag está correta com 't' minúsculo
    }

    void Update()
    {   
        Debug.Log(tag);
        Debug.Log(GameManager.Instance.selectedButton);
        if(tag == GameManager.Instance.selectedButton)
        {
            if (button != null)
            {
                Debug.Log("Button selected");
                button.onClick.Invoke();
            }
        }
        if(tag == GameManager.Instance.preButton)
        {
            imageComponent.color = Color.yellow;
        }
        else
        {
            imageComponent.color = Color.white;
        }
    }
}
