using System;
using UnityEngine;

namespace YQFM
{
    public class UIHelper
    {
        public static Component GetOneUI(string uiName,Type t)
        {
           GameObject go =  ResMgr.Inst.LoadPrefab(uiName);
           var obj = GameObject.Instantiate(go);
           var ret = obj.AddComponent(t);
           return ret;
        }
    }
}