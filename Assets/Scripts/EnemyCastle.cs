using CDEnum;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public override void CreateLivingEntity(int index)
    {
        var obj = Instantiate(m_enemyObjArray[index], transform.position, Quaternion.identity);
        var enemyComp = obj.GetComponent<Unit>();
        enemyComp.Init(EntityType.Enemy);
        obj.SetActive(true);
    }
}
