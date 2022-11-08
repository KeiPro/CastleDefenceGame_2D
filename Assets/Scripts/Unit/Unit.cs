using UnityEngine;
using Enums;

public class Unit : LivingEntity
{
    [SerializeField] private UnitData m_unitData;
    public UnitData UnitData { set { m_unitData = value; } }

    private int m_moveDir;

    public void Init(EntityTypeEnum entityType)
    {
        GetComponent<SpriteRenderer>().sprite = m_unitData.Sprite;
        gameObject.name = m_unitData.UnitName;

        switch (entityType)
        {
            case EntityTypeEnum.Alliance:
                m_moveDir = 1;
                break;
            case EntityTypeEnum.Enemy:
                m_moveDir = -1;
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 200 / 255f, 200 / 255f);
                break;
            case EntityTypeEnum.Netural:
                break;
            default:
                break;
        }
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
        transform.Translate(Vector2.right * m_moveDir * Time.deltaTime * m_unitData.MoveSpeed);
    }
}
