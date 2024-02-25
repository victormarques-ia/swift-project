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

    public void onClickSelectPhrase(string phrase) {
        GameManager.Instance.selectedPhrase = (PhrasesTaylorSwiftEra)Enum.Parse(typeof(PhrasesTaylorSwiftEra), phrase);
        SceneManager.LoadSceneAsync("BraceletScene");
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
