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

    public override void CreateLivingEntity()
    {
        EnemyTypeEnum enemyType = GetMonsterTypeByRandom();
        var enemy = EnemyFactory.GetEnemy(enemyType);
        var obj = Instantiate(m_enemyObjArray[0], transform.position, Quaternion.identity);
        obj.AddComponent(enemy);
            var enemyComp = obj.GetComponent<Enemy>();
        enemyComp.Init();
        obj.SetActive(true);
    }

    private EnemyTypeEnum GetMonsterTypeByRandom()
    {
        int monsterMaxCount = Enum.GetValues(typeof(EnemyTypeEnum)).Length;
        int index = UnityEngine.Random.Range(0, monsterMaxCount);
        return (EnemyTypeEnum)index;
    }
}
