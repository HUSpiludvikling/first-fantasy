using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack {

    public virtual void TakeAction(PlayerStats ps, float amount)
    {
        ps.TakeDamage(amount);
    }
}
