using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IRed
{
    public void UpdateRes(bool bRed);

    IRed Parent { get; set; }
}