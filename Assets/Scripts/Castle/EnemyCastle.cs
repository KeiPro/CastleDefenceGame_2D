using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public class EnemyCastle : CastleBase
{
    [SerializeField] private List<UnitData> m_unitDataList;
    [SerializeField] private GameObject m_unitObj;

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
        int randomIndex = GetMonsterTypeByRandom();
        var obj = Instantiate(m_unitObj, transform.position, Quaternion.identity);
        var unitComp = obj.GetComponent<Unit>();

        //데이터 셋팅이 이루어지고 Init을 해야 한다.
        unitComp.UnitData = m_unitDataList[randomIndex];
        unitComp.Init(EntityTypeEnum.Enemy);
        obj.SetActive(true);
    }

    private int GetMonsterTypeByRandom()
    {
        int monsterMaxCount = m_unitDataList.Count;
        int random = UnityEngine.Random.Range(0, monsterMaxCount);
        return random;
    }
}
