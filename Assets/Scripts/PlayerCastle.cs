using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CDEnum;

public class PlayerCastle : CastleBase
{
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
        var entitytypeEnum = EntityType.Alliance;

        Texture2D characterResource = InitGameDatas.Instance.CharacterResourceArray[index] as Texture2D;

        GameObject characterObj = new GameObject(characterResource.name);
        var imageComp = characterObj.AddComponent<SpriteRenderer>();
        Rect rect = new Rect(0, 0, characterResource.width, characterResource.height);
        imageComp.sprite = Sprite.Create(characterResource, rect, new Vector2(0.5f, 0.5f));
    }
}
