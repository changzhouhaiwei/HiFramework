using System;
using System.Collections;
using System.Resources;
using UnityEngine;
using YQFM;
using xasset;


public class Main : MonoBehaviour
{
    [Tooltip("文件校验模式，对于带hash的文件名，其实使用 size 校验就可以了")] [SerializeField]
    private VerifyMode verifyMode = VerifyMode.Size;

    private IEnumerator Start()
    {
        Versions.VerifyMode = verifyMode;
        //初始化xasset 主要用来完成平台路径的设置以及母包的清单文件的加载
        var operation = Versions.InitializeAsync();
        yield return operation;
        xasset.Logger.I("Initialize: {0}", operation.status);
        xasset.Logger.I("API Version: {0}", Versions.APIVersion);
        xasset.Logger.I("Manifests Version: {0}", Versions.ManifestsVersion);
        xasset.Logger.I("SimulationMode: {0}", Versions.SimulationMode);
        xasset.Logger.I("OfflineMode: {0}", Versions.OfflineMode);
        xasset.Logger.I("EncryptionEnabled: {0}", Versions.EncryptionEnabled);
        xasset.Logger.I("Application.platform: {0}", Application.platform);

        DontDestroyOnLoad(gameObject);
        
        
        InitFramework();
        StartSceneJump();
    }

    void StartSceneJump()
    {
        TSceneMgr.Inst.OpenSceneSync("LogoScene");
    }

    void InitFramework()
    {
        UIManager.Inst.Init();
        ResMgr.Inst.Init();
        EventMgr.Inst.Init();
        TSceneMgr.Inst.Init();
    }
}