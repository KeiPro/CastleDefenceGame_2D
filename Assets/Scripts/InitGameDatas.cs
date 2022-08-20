using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGameDatas : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        string characterImagesPath = $"{Strings.Images}/{Strings.Characters}";
        Object[] characters = Resources.LoadAll<Texture2D>(characterImagesPath);

        Debug.Log(characters.Length);


    }
}
