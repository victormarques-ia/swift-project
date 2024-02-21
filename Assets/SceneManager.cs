using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene() {
        print("Changing Scene");
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }	
}
