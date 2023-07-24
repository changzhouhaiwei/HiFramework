using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YQFM;

namespace Logic
{
    public class MainUINode:UIBaseCanvas
    {
        public static readonly string Path = "Assets/AssetBundle/Prefab/MainUI/MainUINode.prefab";
        
        protected override void Start()
        {
            base.Start();
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"m1Btn","GameObject/m1Btn==OnButtonClick"},
                {"m2Btn","GameObject/m2Btn==OnButtonClick"},
                {"m3Btn","GameObject/m3Btn==OnButtonClick"},
                {"m4Btn","GameObject/m4Btn==OnButtonClick"},
                {"m5Btn","GameObject/m5Btn==OnButtonClick"},
                
                {"fightBtn","fightBtn==OnButtonClick2"},
            };
            LoadUIInfo(dic);
        }

        public override void OnButtonClick(GameObject target)
        {
            Debug.Log(target.name);
        }

        public void OnButtonClick2(GameObject target)
        {
            if (target == m_uiInfo["fightBtn"])
            {
                Debug.Log("hahah");
                TSceneMgr.Inst.OpenSceneAsync("FightScene", typeof(FightSceneNode));
            }
        }
        
    }
}
