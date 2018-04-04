using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystem : MonoBehaviour
{
    public enum Turn
    {
        PlayerTurn, EnemyTurn
    };

    public Enemy enemy;
    public Turn turn;
    public GameObject playerUI;
    public PlayerStats player;
    public Enemy[] enemyList;



    public void StartBattle()
    {
        enemy = GetRandomEnemy();
    }

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        StartBattle();
    }

    // Update is called once per frame
    void Update()
    {

        if (turn == Turn.EnemyTurn)
        {
            playerUI.SetActive(false);
            PerformEnemyAttack(GetRandomEnemyAttack(enemy), player);
            ChanceTurn();
        }
        else if (turn == Turn.PlayerTurn)
        {
            playerUI.SetActive(true);
        }

    }

    public Enemy GetRandomEnemy()
    {
        return enemyList[UnityEngine.Random.Range(0, enemyList.Length)];
    }

    public AttackStats GetRandomEnemyAttack(Enemy enemy)
    {
        return enemy.attacks[UnityEngine.Random.Range(0, enemy.attacks.Length)];
    }

    public void PerformEnemyAttack(AttackStats attackStats, PlayerStats player)
    {
        switch (attackStats.attackType)
        {
            case AttackType.Single:
                player.TakeDamage(attackStats.damage);
                break;
            case AttackType.AOE:
                break;
            case AttackType.Dot:
                break;
        }
    }

    public void ChanceTurn()
    {
        if (turn == Turn.EnemyTurn)
        {
            turn = Turn.PlayerTurn;
        }

        else
        {
            turn = Turn.EnemyTurn;
        }
    }
}
