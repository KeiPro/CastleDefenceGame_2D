using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_currentMonsterWaveText;

    private string m_monsterWave = "Monster Wave : ";
    private void Start()
    {
        m_currentMonsterWaveText.text = m_monsterWave + "1";
    }

    public void OnClickGregolaTest()
    {
        MainGameController.Instance.RunGregolaWave(SetCurrentWaveText);
    }

    public void SetCurrentWaveText(int monsterWave)
    {
        m_currentMonsterWaveText.text = m_monsterWave + $"{monsterWave}";
    }
}
