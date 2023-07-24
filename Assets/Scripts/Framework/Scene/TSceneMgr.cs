using System;
using System.Threading.Tasks;
using UnityEngine;
using xasset;
using YQFM;

public class TSceneMgr
{
    private static TSceneMgr _instance;
    
    private event Action<xasset.Scene> m_sceneComplete;
    private Type m_curSceneRootT;
    private string m_curSceneName;

    private Type m_lastSceneRootT;
    private string m_lastSceneName;
    
    public static TSceneMgr Inst
    {
        get
        {
            if (_instance == null)
            {
                _instance = new TSceneMgr();
            }

            return _instance;
        }
    }

    public void Init()
    {
        m_sceneComplete = new Action<Scene>(SceneAsyncComplete);
    }
    
    public void OpenSceneSync(string sceneName)
    {
        var sceneAssetRequest = xasset.Scene.Load("Assets/Scenes/" + sceneName + ".unity");
    }

    public async void OpenSceneSync(string sceneName,Type t)
    {
        var sceneAssetRequest = xasset.Scene.Load("Assets/Scenes/" + sceneName + ".unity");
        await Task.Delay(1);
        
        var obj = new GameObject("sceneObj");
        obj.AddComponent(t);
        
        UIManager.Inst.ClearLastSceneUI();
    }

    public xasset.Scene OpenSceneAsync(string sceneName,Type t)
    {
        m_lastSceneName = m_curSceneName;
        m_lastSceneRootT = m_curSceneRootT;
        
        m_curSceneName = sceneName;
        m_curSceneRootT = t;
        var path = "Assets/Scenes/" + sceneName + ".unity";
        var ret = xasset.Scene.LoadAsync(path);
        UIManager.Inst.DoLoadingScene(ret,ref m_sceneComplete);
        ret.completed += m_sceneComplete;
        return ret;
    }

    private void SceneAsyncComplete(xasset.Scene scene)
    {
        Debug.Log("scene async loaded  {m_curSceneName}");
        UIManager.Inst.ClearLastSceneUI();
        
        var obj = new GameObject("sceneObj");
        obj.AddComponent(m_curSceneRootT);
    }

    public void BackToLastScene()
    {
        OpenSceneAsync(m_lastSceneName, m_lastSceneRootT);
    }
    
}