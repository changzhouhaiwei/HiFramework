using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YQFM;

namespace Logic
{
    public sealed class TODOMainNode : UIBaseCanvas
    {
        public static string Path = "Assets/AssetBundle/Prefab/TODO/TODOMainNode.prefab";
        
        public Sprite sp;
        
        // Start is called before the first frame update
        protected override void Start()
        {
            Debug.Log("start 啊");
            base.Start();
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"addBtn","addBtn==OnButtonClick"},
                {"scollView","Scroll View"},
                {"cellObj" , "Cell"},
            };
            LoadUIInfo(dic);
        }

        
        
        public override void OnButtonClick(GameObject target)
        {
            if (target == m_uiInfo["addBtn"])
            {
                Debug.Log("didida");
            }
        }

        void UpdateScrollView()
        {   
            
        }
        
        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
