using System;
using UnityEngine;

public class MainGameController : Singleton<MainGameController>
{
    private int m_monsterWaveNumber = 1;

    private void Start()
    {
    }
    public void AddMonsterWaveNumber(int addNumber)
    {
        m_monsterWaveNumber += addNumber;
    }

    public void RunGregolaWave(Action<int> resultCallback)
    {
        Debug.Log("�׷������ ������ ���۵˴ϴ�.");

        int rand = UnityEngine.Random.Range(0, 100);
        if (rand < 30)
        {
            OnSuccessGregolaWave();
            Debug.Log("�׷������ ���迡�� ����Ǿ����ϴ�.");

            resultCallback?.Invoke(m_monsterWaveNumber);
        }
        else
        {
            OnFailGregolaWave();
            Debug.Log("�׷������ ���迡�� �����Ͽ����ϴ�.");
        }
    }

    private void OnSuccessGregolaWave()
    {
        m_monsterWaveNumber++;
    }

    private void OnFailGregolaWave()
    { 
    
    }
}
