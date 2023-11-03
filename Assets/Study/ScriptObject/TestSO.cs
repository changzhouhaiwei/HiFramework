using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
struct Dailo
{
    public string a;
    public int b;
    public float c;
}

public class TestSO : ScriptableObject
{
    Dailo _dailo;
    public float juju;
    public string gege;
    public int dd;
}
