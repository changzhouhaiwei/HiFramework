using System.Collections;
using System.Collections.Generic;
using Logic;
using UnityEngine;
using YQFM;


public class TODOScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("todo scene");
        var node = UIHelper.GetOneUI(TODOMainNode.Path, typeof(TODOMainNode));
        UIManager.Inst.OpenModule(node as TODOMainNode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
}
