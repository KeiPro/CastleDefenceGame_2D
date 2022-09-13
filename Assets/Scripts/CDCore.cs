using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDCore : Singleton<CDCore>
{
    public Object[] CharacterResourceArray => m_characterResourceArray;
    
    private Object[] m_characterResourceArray = null;

    private void Start()
    {
        string characterImagesPath = $"{Strings.Images}/{Strings.Characters}";
        m_characterResourceArray = Resources.LoadAll<Texture2D>(characterImagesPath);
    }
}
