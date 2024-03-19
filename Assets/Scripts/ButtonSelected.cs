using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonSelected : MonoBehaviour
{
    string tag;
    Button button;
    Image imageComponent;
    TextMeshProUGUI textChild;
    void Start()
    {
        button = GetComponent<Button>();
        imageComponent = GetComponent<Image>();
        textChild = GetComponentInChildren<TextMeshProUGUI>();
        tag = this.gameObject.tag;
    }

    void Update()
    {   
        Debug.Log(tag);
        // Debug.Log(GameManager.Instance.selectedButton);
        if(tag == GameManager.Instance.selectedButton)
        {
            if (button != null)
            {
                Debug.Log("Button selected");
                button.onClick.Invoke();
            }
        }

        if(tag == GameManager.Instance.preButton && textChild == null)
        {
            imageComponent.color = Color.yellow;
        }
        else
        {
            Debug.Log("Tag: " + tag + " PreButton: " + GameManager.Instance.preButton + " TextChild: " + textChild);
            if (tag == GameManager.Instance.preButton && textChild != null)
            {
                textChild.color = Color.yellow;
            }
            else if (textChild != null)
            {
                textChild.color = Color.white;
            }
            else
            {
                imageComponent.color = Color.white;
            }
        }
    }
}
