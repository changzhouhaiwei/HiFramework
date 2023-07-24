using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YQFM
{
    public class UIManager
    {
        private int m_moduleZorderBase = 10000;
        private int m_newbieZorderBase = 20000;

        private List<UIBaseCanvas> m_moduleList;
        private List<UIBaseCanvas> m_lastSceneModuleList;

        private static UIManager _instance;
        private GameObject m_mgrNode;

        private Transform m_moduleTran;
        private Transform m_loadingTran;
        
        //单例
        public static UIManager Inst
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UIManager();
                }
                return _instance;
            }
        }

        public void Init()
        {
            m_moduleList = new List<UIBaseCanvas>();
            var go = ResMgr.Inst.LoadPrefab("Assets/AssetBundle/Prefab/Common/UIMgrNode.prefab");
            var obj = GameObject.Instantiate(go);
            m_moduleTran = obj.transform.Find("ModuleCanvas");
            m_loadingTran = obj.transform.Find("LoadingCanvas");
            m_loadingTran.gameObject.AddComponent<UISceneLoading>();
            m_loadingTran.gameObject.SetActive(false);
        }

        public void OpenPopupModule(UIBaseCanvas node)
        {
            m_moduleList.Add(node);
            node.gameObject.GetComponent<Canvas>().sortingOrder = m_moduleZorderBase + 100 * m_moduleList.Count;
        }

        public void OpenPopupModule(Type t)
        {
        }
        
        public void OpenModule(UIBaseCanvas node)
        {
            node.transform.SetParent(m_moduleTran,false);
            OpenPopupModule(node);
            foreach (var v in m_moduleList)
            {
                v.gameObject.SetActive(v == node);
            }
        }

        public void OpenSceneBaseUI(UIBaseCanvas node)
        {
            
        }

        public void BackToMainUI()
        {
            
        }

        public void ReturnOneNode(UIBaseCanvas node)
        {
            var idx = m_moduleList.FindIndex(_node => _node == node);
            bool bFix = idx != m_moduleList.Count - 1;
            m_moduleList.Remove(node);
            GameObject.DestroyImmediate(node.gameObject);
            if (bFix)
            {
               FixZorder();
            }
        }

        private void FixZorder()
        {
            int idx = 0;
            foreach (var v in m_moduleList)
            {
                v.gameObject.GetComponent<Canvas>().sortingOrder = m_moduleZorderBase + 100 * idx;
                idx++;
            }            
        }

        public void DoLoadingScene(xasset.Scene scene,ref Action<xasset.Scene> complete)
        {
            m_loadingTran.gameObject.SetActive(true);
            m_loadingTran.gameObject.GetComponent<UISceneLoading>().ExcuteLoading(scene,ref complete);
        }

        public void ClearLastSceneUI()
        {
            m_lastSceneModuleList = new List<UIBaseCanvas>(m_moduleList);
            foreach (var v in m_moduleList)
            {
                v.gameObject.SetActive(false);
            }
            m_moduleList.Clear();
        }
        
 
    }
}
