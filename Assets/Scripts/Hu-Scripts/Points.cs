using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public Text Text;

    public int score = 0;

    private void Awake()
    {
        GetScore(0);
    }

    public void GetScore(int input)
    {
        score += input;
    }
}
