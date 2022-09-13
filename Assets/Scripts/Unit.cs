using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CDEnum;

public class Unit : LivingEntity
{
    private EntityType m_entityType;

    public void Init(EntityType entityType)
    {
        m_hp = 100;
        m_moveSpeed = 3.0f;
        m_entityType = entityType;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
    }

    public override void OnDamage(float damage)
    {
        base.OnDamage(damage);
    }

    private void Update()
    {
        UpdateMove();
    }

    private void UpdateMove()
    {
        switch (m_entityType)
        {
            case EntityType.Alliance:
                transform.Translate(Vector3.right * Time.deltaTime * m_moveSpeed);
                break;

            case EntityType.Enemy:
                transform.Translate(Vector3.left * Time.deltaTime * m_moveSpeed);
                break;

            case EntityType.Netural:

                break;
            default:
                break;
        }
    }
}
