using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public void onClickSelectEra(string era) {
        GameManager.Instance.selectedEra = (TaylorSwiftEra)Enum.Parse(typeof(TaylorSwiftEra), era);
        SceneManager.LoadSceneAsync("PhraseScene");
    }

    public void onClickSelectPhrase(int phraseIndex) {
        List<string> phrases = GameManager.Instance.GetPhrasesForSelectedEra();
        
        if (phraseIndex >= 0 && phraseIndex < phrases.Count)
        {
            GameManager.Instance.selectedPhrase = phrases[phraseIndex];
            SceneManager.LoadSceneAsync("BraceletScene");
        }
        else
        {
            Debug.LogError($"Phrase index {phraseIndex} is out of range for the selected era.");
        }
    }

    public void onClikUseBracelet() {
        SceneManager.LoadSceneAsync("EndScene");
        print("Bracelet usado: " + GameManager.Instance.selectedEra.ToString() + " - " + GameManager.Instance.selectedPhrase);
    }

    public void onClickNewBracelet() {
        SceneManager.LoadSceneAsync("ErasScene");
    }

    public void onClickExit() {
        SceneManager.LoadSceneAsync("MenuScene");
    }
}