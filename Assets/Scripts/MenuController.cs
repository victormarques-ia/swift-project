using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void start() {
       SceneManager.LoadSceneAsync("ErasScene");
    }

    public void backFromErasScene() {
       SceneManager.LoadSceneAsync("MenuScene");
    }

    public void rules() {
       SceneManager.LoadSceneAsync("RulesScene");
    }

    public void backFromRulesScene() {
       SceneManager.LoadSceneAsync("MenuScene");
    }

    public void exit() {
       print("Exit");
    }
}
