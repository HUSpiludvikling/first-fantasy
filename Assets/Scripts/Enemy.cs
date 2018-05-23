using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemy/Enemy", order = 2)]
public class Enemy :ScriptableObject {

    public string Name;
    public float MaxHealth;
    public float Health;

    public float Damage;
    public int Reward;
    public AttackStats[] attacks;
    public GameObject RewardPanel;
    public GameObject RewardText;
    public GameObject points;


    public void GetRekt(float input)
    {
        Health = Health - input;

        if (Health <= 0)
        {
            GameObject.FindGameObjectWithTag("CombatInfo").SetActive(false);
            RewardPanel.SetActive(true);
            GameObject.FindGameObjectWithTag("BattleManager").GetComponent<Timer>().StartTimer();
            GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleSystem>().EarnReward(Reward);
            RewardText.GetComponent<Text>().text = "You Got " + Reward + " Monies for a total of " + points.GetComponent<Points>().score;

            //Destroy(this);
        }
    }

}
