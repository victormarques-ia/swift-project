using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ButtonPhraseManager : MonoBehaviour
{
    public Button button;
    public int phraseIndex;

    void Start()
    {
        List<string> phrases = GameManager.Instance.GetPhrasesForSelectedEra();
        
        if (phraseIndex >= 0 && phraseIndex < phrases.Count)
        {
            button.GetComponentInChildren<TextMeshProUGUI>().text = "“" + phrases[phraseIndex] + "”";
        }
        else
        {
            Debug.LogError("Phrase index out of range for selected era!");
            button.gameObject.SetActive(false); 
        }
    }
}
