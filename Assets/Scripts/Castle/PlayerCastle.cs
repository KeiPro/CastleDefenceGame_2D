using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class PlayerCastle : CastleBase
{
    [SerializeField] private List<UnitData> m_unitDataList;
    [SerializeField] private GameObject m_unitObj;

    public static PlayerCastle Instance;

    private void OnEnable()
    {
        if (Instance != null)
        {
            Debug.LogError("There is already exist " + name + " instance in the scene.");
            Destroy(this);
            return;
        }

        Instance = this;
    }

    public override void CreateLivingEntity(int index = 0)
    {
        var obj = Instantiate(m_unitObj, transform.position, Quaternion.identity);
        var unitComp = obj.GetComponent<Unit>();

        unitComp.UnitData = m_unitDataList[index];
        unitComp.Init(EntityTypeEnum.Alliance);

        obj.SetActive(true);

        //Texture2D characterResource = CDAssetManager.Instance.CharacterResourceArray[0] as Texture2D;

        //GameObject characterObj = new GameObject(characterResource.name);
        //var imageComp = characterObj.AddComponent<SpriteRenderer>();
        //Rect rect = new Rect(0, 0, characterResource.width, characterResource.height);
        //imageComp.sprite = Sprite.Create(characterResource, rect, new Vector2(0.5f, 0.5f));
    }
}
