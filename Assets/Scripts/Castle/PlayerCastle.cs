using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class PlayerCastle : CastleBase
{
    [SerializeField] private GameObject[] m_playerUnitObjArray;

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
        var unit = UnitFactory.GetUnit(EntityTypeEnum.Alliance, index);

        var obj = Instantiate(m_playerUnitObjArray[0], transform.position, Quaternion.identity);
        obj.AddComponent(unit);

        var unitComp = obj.GetComponent<Unit>();
        unitComp.Init();
        obj.SetActive(true);

        // 추후 활용. Resources.Load를 사용하는 방식인데 이 부분도 추후에는 Atlas를 이용하는 방식으로 수정되어야 함.

        //Texture2D characterResource = CDAssetManager.Instance.CharacterResourceArray[0] as Texture2D;

        //GameObject characterObj = new GameObject(characterResource.name);
        //var imageComp = characterObj.AddComponent<SpriteRenderer>();
        //Rect rect = new Rect(0, 0, characterResource.width, characterResource.height);
        //imageComp.sprite = Sprite.Create(characterResource, rect, new Vector2(0.5f, 0.5f));
    }
}
