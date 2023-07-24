using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YQFM;

namespace Logic
{
    public class FightUI : UIBaseCanvas
    {
        public static readonly string Path = "Assets/AssetBundle/Prefab/FightUI/FightUINode.prefab";
        // Start is called before the first frame update

        protected override void Start()
        {
            base.Start();
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"backBtn","backBtn==OnButtonClick"},
            };
            LoadUIInfo(dic);
        }

        public override void OnButtonClick(GameObject target)
        {
            TSceneMgr.Inst.BackToLastScene();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
    
}
