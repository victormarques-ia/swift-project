using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void start() {
       UnityEngine.SceneManagement.SceneManager.LoadScene("ErasScene");
    }

    public void backFromErasScene() {
       UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");
    }
}
