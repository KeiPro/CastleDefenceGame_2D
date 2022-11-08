using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour, IDamageable
{
    protected string m_name;
    protected float m_hp;
    protected float m_moveSpeed;
    protected int m_damage;

    private bool m_isDead;

    public virtual void OnDamage(float damage)
    {
        m_hp -= damage;

        if (m_hp <= 0 && m_isDead == false)
        {
            Die();
        }
    }

    protected virtual void OnEnable()
    {
        m_isDead = false;
    }

    private void Die()
    {
        m_isDead = true;
    }
}
