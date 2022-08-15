using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : Singleton<MainGameController>
{
    private int m_monsterWaveNumber = 1;

    public void AddMonsterWaveNumber(int addNumber)
    {
        m_monsterWaveNumber += addNumber;
    }
}
