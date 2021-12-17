using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonLoading : MonoBehaviour {

    public void LoadSceneNum(int num)
    {
        if (num < 0 || num >= SceneManager.sceneCountInBuildSettings)
        {
            Debug.LogWarning("Can`t load scene num " + num + ", SceneManager only has" + SceneManager.sceneCountInBuildSettings + "");
            return;
        }
        LoadingScreenManager.LoadScene(num);
    }
}
