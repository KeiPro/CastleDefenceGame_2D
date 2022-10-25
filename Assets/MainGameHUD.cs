using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameHUD : MonoBehaviour
{
    public void OnClickUnitButton(int index)
    {
        PlayerCastle.Instance.CreateLivingEntity(index);
    }
}
