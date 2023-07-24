using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Logic
{
    public class LogoScene : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Invoke(nameof(EnterLoginScene),1);
        }

        void EnterLoginScene()
        {
            TSceneMgr.Inst.OpenSceneSync("LoginScene",typeof(LoginSceneNode));
        }
        
    }
    
}
