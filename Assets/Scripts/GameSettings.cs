using System;
using UnityEngine;

public enum ServerURLType
{
    INTRA_URL = 1,          // 内网
    OUTER_URL = 2,          // 外网
    ISBN_URL = 3,           // 版号包
    CE_URL = 4,             // CE版号包
    OUTER_URL_2 = 5,        // 外网2
}

public enum ChannelPlatform
{
    None,                   // 快速
    IOS_YQ,                 // 云岐_IOS
    ANDROID_YQ,             // 云岐_Android
}

[CreateAssetMenu(menuName = "GameSettings", fileName = "GameSettings", order = 0)]
public class GameSettings : ScriptableObject
{
    [Header("游戏的日志模式")]
    public bool logMode;

    [Header("是否开启GM")]
    public bool gmMode;

    [Header("游戏的运行帧频，默认30帧")]
    public int GameFrameRate = 30;

    [Header("打包服务器地址选择")]
    public ServerURLType urlType = ServerURLType.OUTER_URL;

    [Header("打包平台选择")]
    public ChannelPlatform platform = ChannelPlatform.None;

    [Header("游戏大版本")]
    public int AppVersion = 1;

    [Header("资源版本号")]
    public int major;
    public int minor;
    [Tooltip("构建的版本号")] public int build;

#if UNITY_EDITOR
    public void AddVersion()
    {
        build += 1;
        UnityEditor.EditorUtility.SetDirty(this);
        UnityEditor.AssetDatabase.SaveAssets();
    }
#endif

    public string GetVersion()
    {
        var ver = new Version(major, minor, build);
        return ver.ToString();
    }

    public string GetServerAddress()
    {
        switch (urlType)
        {
            case ServerURLType.INTRA_URL:
                return "http://192.168.0.210/";
            case ServerURLType.OUTER_URL:
                return "http://121.89.182.226/";
            case ServerURLType.ISBN_URL:
                return "http://39.101.209.41/";
            case ServerURLType.OUTER_URL_2:
                return "http://101.37.19.80/";
            case ServerURLType.CE_URL:
            default:
                return "";
        }
    }

    public string GetServerVersionURL()
    {
        return $"{GetServerAddress()}ver/version.dat";
    }

    public string GetDownloadBundlesURL()
    {
        return $"{GetServerAddress()}ver/update/Bundles/";
    }

    public string GetServerAreaURL()
    {
        return $"{GetServerAddress()}get_server.php";
    }
}
