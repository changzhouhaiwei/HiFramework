using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//前缀树测试,实现红点系统
public class QZTreeTest : MonoBehaviour
{
    private Dictionary<string, RedObj> m_dic;
    // Start is called before the first frame update
    void Start()
    {
        m_dic = new Dictionary<string, RedObj>();
        
        Test();
    }

    public void Test()
    {
        string[] arr = { "Button1","Button11","Button12","Button111","Button112","Button123"};
        foreach (var key in arr)
        {
            var tempTran = transform.Find(key);
            var imageComp = tempTran.gameObject.GetComponent<RedObj>();
            if (imageComp)
            {
                m_dic[key] = imageComp;
            }
        }
        
        SetRedParent("Button11","Button1");
        SetRedParent("Button12","Button1");
        SetRedParent("Button111","Button11");
        SetRedParent("Button112","Button11");
        SetRedParent("Button123","Button12");
    }

    public void SetRedParent(string key1,string key2)
    {
        RedObj obj1 = m_dic[key1];
        RedObj obj2 = m_dic[key2];

        obj1.Parent = obj2;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            m_dic["Button123"].UpdateRes(true);
        }
    }
}
