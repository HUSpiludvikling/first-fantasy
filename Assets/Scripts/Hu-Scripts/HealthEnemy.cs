using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Enemy))]
public class HealthEnemy : MonoBehaviour {
    public float life = 100f;
    private Enemy ThatEnemy;
	// Use this for initialization
	void Start () {
        ThatEnemy = GetComponent<Enemy>();
        life = ThatEnemy.MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GetRekt(float input) 
    {
        life = life - input;

        if (life<=0)
        {
            GameObject.FindGameObjectWithTag("CombatInfo").SetActive(false);
            GameObject.FindGameObjectWithTag("RewardPanel").SetActive(true);
            GameObject.FindGameObjectWithTag("RewardPanel").GetComponent<Text>().text = "You Got" + ThatEnemy.Reward + " Monies";
            GameObject.FindGameObjectWithTag("Player").GetComponent<Points>().GetScore(ThatEnemy.Reward);
            GameObject.FindGameObjectWithTag("BattleManager").GetComponent<Timer>().StartTimer();
            Destroy(gameObject);
        }
    }
}
