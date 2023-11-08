using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public struct TODOStruct
{
    public string description;
    public string imagePath;
}

[CreateAssetMenu(menuName ="Data/ScriptTODO",fileName = "TODOData")]
public class TODOData:ScriptableObject
{
    public List<TODOStruct> todoList;
    public string title;
}
