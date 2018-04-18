using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDisplayEnemy : MonoBehaviour {

    public Enemy enemy;
    public Text HealthText, NameText;


    // Use this for initialization
    void Start () {
        enemy = GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleSystem>().enemy;
        NameText.text = enemy.Name;
    
	}
	
	// Update is called once per frame
	void Update () {
        HealthText.text = enemy.Health.ToString("0");
	}
}
