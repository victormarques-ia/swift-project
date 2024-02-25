using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class MenuController : MonoBehaviour
{
    public async void start() {
         SceneManager.LoadSceneAsync("HistoryScene");
         await Task.Delay(3000);
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
       Application.Quit();
    }
}
