using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Kan bruges til at skifte scener.
/// </summary>
public class Timer : MonoBehaviour {
    public float Tid;
    public string loadString;
	// Use this for initialization
	void Start ()
    {
        
    }

    public void StartTimer()
    {
        StartCoroutine(Delay(Tid));
    }
    /// <summary>
    /// Starter timeren med en ny scene
    /// </summary>
    /// <param name="loadstring">Den nye scene</param>
    public void StartTimer(string loadstring)
    {
        loadString = loadstring;
        StartTimer();
    }
    /// <summary>
    /// Starter timeren med en ny tid.
    /// </summary>
    /// <param name="tid">Den nye tid i sekunder.</param>
    public void StartTimer(float tid)
    {
        Tid = tid;
        StartTimer();
    }
    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator Delay(float tid)
    {
        //Laver først
        print("noget");
        yield return new WaitForSeconds(tid);
        //Laver bagefter
        print("jøde");
        SkiftScene();
    }

    private void SkiftScene()
    {
        SceneManager.LoadScene(loadString);
    }
}
