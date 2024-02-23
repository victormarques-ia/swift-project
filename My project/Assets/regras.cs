using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class regras : MonoBehaviour
{
    public void RuleScene()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
