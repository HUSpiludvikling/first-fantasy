using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour {
    float life = 100f;

    public void TakeDamage(float input)
    {
        life = life - input;

        if (life<=0)
        {
            SceneManager.LoadScene("Lose Scene");
        }
    }
}
