using System.Collections;
using System.Collections.Generic;
using Logic;
using UnityEngine;
using YQFM;

public class HomeSceneNode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HomeSceneNode start");
        var node = UIHelper.GetOneUI(MainUINode.Path, typeof(MainUINode));
        UIManager.Inst.OpenModule(node as MainUINode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
