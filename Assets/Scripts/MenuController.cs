using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame() {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(LoadScenesWithDelay());
    }

    IEnumerator LoadScenesWithDelay() {
        SceneManager.LoadScene("HistoryScene");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("ErasScene");
    }

    public void BackFromErasScene() {
       SceneManager.LoadScene("MenuScene");
    }

    public void Rules() {
       SceneManager.LoadScene("RulesScene");
    }

    public void BackFromRulesScene() {
       SceneManager.LoadScene("MenuScene");
    }

    public void Exit() {
       Debug.Log("Exit");
       Application.Quit();
    }
}
