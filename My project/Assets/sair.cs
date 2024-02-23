using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sair : MonoBehaviour
{
    public void ExitScene()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
