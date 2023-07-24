using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YQFM;

namespace Logic
{
    public class FightSceneNode : BaseScene
    {
        // Start is called before the first frame update
        void Start()
        {
            var node = UIHelper.GetOneUI(FightUI.Path, typeof(FightUI));
            UIManager.Inst.OpenModule(node as FightUI);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
    
}
