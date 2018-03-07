using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public string loadString;
    public void LoadScene()
    {
        SceneManager.LoadScene(loadString);
    }
}
