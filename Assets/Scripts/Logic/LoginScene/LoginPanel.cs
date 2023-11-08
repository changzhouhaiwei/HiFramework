using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YQFM;

namespace Logic
{
    public sealed class LoginPanel : UIBaseCanvas
    {
        public static string Path = "Assets/AssetBundle/Prefab/Login/LoginPanel.prefab";

        public Sprite sp;
        
        // Start is called before the first frame update
        protected override void Start()
        {
            Debug.Log("start 啊");
            base.Start();
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"loginBtn","LoginBtn==OnButtonClick"},
                {"testBtn","testBtn==OnButtonClick"},
                {"image","Image====Image"}
            };
            LoadUIInfo(dic);
        }

        public  override  void  OnButtonClick(GameObject target)
        {
            if (target == m_uiInfo["loginBtn"])
            {
                // Debug.Log("hellowade1");
                var image = m_compInfo["imageComp"] as Image;
                var sprite = LoadSprite("Assets/AssetBundle/Sprite/liaotian2.png");
                if (image != null)
                {
                    image.sprite = sprite;
                }
                // LoginHomeScene();
                LoginTODOScene();
            }else if(target == m_uiInfo["testBtn"])
            {
                Debug.Log("hellowade2");
            }
        }

        private void LoginHomeScene()
        {
            TSceneMgr.Inst.OpenSceneAsync("HomeScene",typeof(HomeSceneNode));
        }

        private void LoginTODOScene()
        {
            TSceneMgr.Inst.OpenSceneAsync("TODOScene", typeof(TODOScene));
        }
        
        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
