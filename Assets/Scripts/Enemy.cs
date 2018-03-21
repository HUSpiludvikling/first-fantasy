using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemy/Enemy", order = 2)]
public class Enemy :ScriptableObject {
    
    public float Health;
    public float Damage;

    public AttackStats[] attacks;

}
