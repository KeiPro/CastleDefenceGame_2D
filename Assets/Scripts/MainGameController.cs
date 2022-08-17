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
        Debug.Log("그레골라의 시험이 시작됩니다.");

        int rand = UnityEngine.Random.Range(0, 100);
        if (rand < 30)
        {
            OnSuccessGregolaWave();
            Debug.Log("그레골라의 시험에서 통과되었습니다.");

            resultCallback?.Invoke(m_monsterWaveNumber);
        }
        else
        {
            OnFailGregolaWave();
            Debug.Log("그레골라의 시험에서 실패하였습니다.");
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
