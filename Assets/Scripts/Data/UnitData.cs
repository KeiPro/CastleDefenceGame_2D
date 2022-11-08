using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Scriptable Object/Unit Data")]
public class UnitData : ScriptableObject
{
    [SerializeField]
    private string m_unitName;
    public string UnitName { get { return m_unitName; } }
    [SerializeField]
    private int m_hp;
    public int Hp { get { return m_hp; } }
    [SerializeField]
    private int m_damage;
    public int Damage { get { return m_damage; } }

    [SerializeField]
    private float m_moveSpeed;
    public float MoveSpeed { get { return m_moveSpeed; } }

    [SerializeField]
    private Sprite m_sprite;
    public Sprite Sprite { get { return m_sprite; } }
}
