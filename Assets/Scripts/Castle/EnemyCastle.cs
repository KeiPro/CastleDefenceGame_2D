using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public class EnemyCastle : CastleBase
{
    [SerializeField] private GameObject[] m_enemyObjArray;

    public static EnemyCastle Instance;

    private void OnEnable()
    {
        if (Instance != null)
        {
            Debug.LogError("There is already exsit " + name + " instance in the scene.");
            Destroy(this);
            return;
        }

        Instance = this;
    }

    public override void CreateLivingEntity(int index = 0)
    {
        EnemyUnitTypeEnum enemyType = GetMonsterTypeByRandom();
        var unit = UnitFactory.GetUnit(EntityTypeEnum.Enemy, (int)enemyType);
        var obj = Instantiate(m_enemyObjArray[0], transform.position, Quaternion.identity);
        obj.AddComponent(unit);

        var unitComp = obj.GetComponent<Unit>();
        unitComp.Init();
        obj.SetActive(true);
    }

    private EnemyUnitTypeEnum GetMonsterTypeByRandom()
    {
        int monsterMaxCount = Enum.GetValues(typeof(EnemyUnitTypeEnum)).Length;
        int index = UnityEngine.Random.Range(0, monsterMaxCount);
        return (EnemyUnitTypeEnum)index;
    }
}
