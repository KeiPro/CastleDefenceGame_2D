using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : LivingEntity
{
    public virtual void Init()
    {
        m_hp = 100;
        m_moveSpeed = 3.0f;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
    }

    public override void OnDamage(float damage)
    {
        base.OnDamage(damage);
    }
}
