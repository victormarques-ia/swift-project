using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] private GameObject gameManagerPrefab;

    void Awake()
    {
        if (GameManager.Instance == null)
        {
            var instance = Instantiate(gameManagerPrefab);
            
            DontDestroyOnLoad(instance);
        }
    }
}
