using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDAssetManager : Singleton<CDAssetManager>
{
    public Object[] CharacterResourceArray => m_characterResourceArray;
    
    private Object[] m_characterResourceArray = null;

    private void Start()
    {
        string characterImagesPath = $"{Strings.Images}/{Strings.Characters}";
        m_characterResourceArray = Resources.LoadAll<Texture2D>(characterImagesPath);
    }
}
