using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attack", menuName = "Enemy/Attack", order = 1) ]
public class AttackStats :ScriptableObject {
    public string attackName;
    public AttackType attackType;
    public float damage;

}

public enum AttackType { Single,AOE,Dot}