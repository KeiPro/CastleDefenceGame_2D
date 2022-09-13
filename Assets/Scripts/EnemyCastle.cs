using CDEnum;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCastle : CastleBase
{
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
        Texture2D unitResource = CDCore.Instance.CharacterResourceArray[index] as Texture2D;

        GameObject unitObj = new GameObject(unitResource.name);
        var imageComp = unitObj.AddComponent<SpriteRenderer>();
        Rect rect = new Rect(0, 0, unitResource.width, unitResource.height);
        imageComp.sprite = Sprite.Create(unitResource, rect, new Vector2(0.5f, 0.5f));
        imageComp.flipX = true;

        var unitComp = unitObj.AddComponent<Unit>();
        unitComp.Init(EntityType.Enemy);

        unitObj.transform.position = transform.position;
    }
}
