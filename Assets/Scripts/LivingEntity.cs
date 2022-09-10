using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour, IDamageable
{
    public string m_name;
    public float m_hp;
    public float m_moveSpeed;

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
