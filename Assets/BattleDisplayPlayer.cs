using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDisplayPlayer : MonoBehaviour {

    public PlayerStats player;
    public Text HealthText, NameText;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        NameText.text = "Player";
    }
	
	// Update is called once per frame
	void Update () {
        HealthText.text = player.health.ToString("0");
	}
}
