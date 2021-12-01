using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour {
    public string mLevelToLoad;

    public void LoadLevel()
    {
        //Load the level
        SceneManager.LoadScene(mLevelToLoad);
    }
}
