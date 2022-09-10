using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCastle : Singleton<EnemyCastle>
{
    [SerializeField] private GameObject[] m_enemyObjArray;

    public void CreateMonster(int index)
    {
        var obj = Instantiate(m_enemyObjArray[index], transform.position, Quaternion.identity);
        var enemyComp = obj.GetComponent<Enemy>();
        enemyComp.Init();
        obj.SetActive(true);
    }
}
