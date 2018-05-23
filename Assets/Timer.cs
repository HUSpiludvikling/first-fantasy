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
	// Use this for initializationhh
	void Start ()
    {
        
    }

    public void StartTimer()
    {
        StartCoroutine(Delay(5f));
    }

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
        SceneManager.LoadScene("Landsby (Lobby)");
    }
}
