using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YQFM;

namespace Logic
{
    public sealed class LoginSceneNode : BaseScene
    {
        // Start is called before the first frame update
        void Start()
        {
            var node = UIHelper.GetOneUI(LoginPanel.Path,typeof(LoginPanel));
            UIManager.Inst.OpenModule(node as  LoginPanel);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
    
}
