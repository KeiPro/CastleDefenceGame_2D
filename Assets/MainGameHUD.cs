using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameHUD : MonoBehaviour
{
    public void OnClickCharacterButton(int index)
    {
        CreateCharacterObj(index);
    }

    private void CreateCharacterObj(int index)
    {
        Texture2D characterResource = InitGameDatas.Instance.CharacterResourceArray[index] as Texture2D;

        GameObject characterObj = new GameObject(characterResource.name);
        var imageComp = characterObj.AddComponent<SpriteRenderer>();
        Rect rect = new Rect(0, 0, characterResource.width, characterResource.height);
        imageComp.sprite = Sprite.Create(characterResource, rect, new Vector2(0.5f, 0.5f));
    }
}
