using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public struct Dailo
{
    public string a;
    public int b;
    public float c;
}


[CreateAssetMenu(menuName ="Data/ScriptObj",fileName = "ScriptObj")]
public class TestSO : ScriptableObject
{
    // [SerializeField]
    public Dailo _dailo;
    
    public float juju;
    public string gege;
    public int dd;
}
