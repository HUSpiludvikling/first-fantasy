using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystem : MonoBehaviour {
    public enum Turn
    {
        PlayerTurn, EnemyTurn
    };

    public Enemy enemy;
    public Turn turn;
    public GameObject playerUI;
    public PlayerStats player;



    public void StartBattle(Enemy e)
    {
        enemy = e;
    }

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {

        if (turn == Turn.EnemyTurn)
        {
            playerUI.SetActive(false);
            enemy.attack.TakeAction(player, enemy.Damage);
            ChanceTurn();
        }
        else if (turn == Turn.PlayerTurn)
        {
            playerUI.SetActive(true);
        }

	}

    private void ChanceTurn()
    {
            if (turn == EnemyTurn)
            {
                (turn == PlayerTurn);
            }
        } 
         
    }
}
