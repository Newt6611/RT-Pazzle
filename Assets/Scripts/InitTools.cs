using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitTools : MonoBehaviour
{
    private string toolsName = "GameTools";

    private void Awake() 
    {
        for(int i=0; i<SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if(scene.name == toolsName)
                return;
        }

        SceneManager.LoadScene(toolsName, LoadSceneMode.Additive);
    }
}
