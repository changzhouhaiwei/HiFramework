using UnityEngine;
using xasset;
using System;

namespace YQFM
{
    public class ResMgr
    {
        private static ResMgr _mgr;
        public static ResMgr Inst
        {
            get
            {
                if (_mgr == null)
                {
                    _mgr = new ResMgr();
                }
                return _mgr;
            }
        }

        public void Init()
        {
        
        }

        // public void LoadAssetAsync(string path, Type type, Action<Asset> func)
        // {
        //     Asset.LoadAsync(path, type, func);
        // }
        //
        // public void LoadAssetAsync(string path, Type type, Action func)
        // {
        //     Asset.LoadAsync(path, type, delegate(Asset asset)
        //     { 
        //         // func.Call(asset);
        //         // func.Dispose();
        //     });
        // }

        public Asset LoadAsset(string path, Type type)
        {
            var asset = Asset.Load(path, type);
            return asset;
        }

        public GameObject LoadPrefab(string path)
        {
            var asset = LoadAsset(path, typeof(GameObject));
            GameObject obj = asset.asset as GameObject;
            return obj;
        }

        // 判断本地是否有这个资源
        public bool Exists(string path)
        {
            return Versions.IsDownloaded(path, false);
        }

        // public LuaByteBuffer LoadPb(string assetName) 
        // {
        //     var assetNamePath = "Assets/AssetBundle/Proto/" + assetName + ".bytes";
        //     var asset = LoadAsset(assetNamePath, typeof(TextAsset));
        //     if (asset == null) return null;
        //     var go = asset.asset as TextAsset;
        //     return go == null ? null : new LuaByteBuffer(go.bytes);
        // }

        // public string LoadConfig(string assetName)
        // {
        //     var assetNamePath = "dd";
        //     // var assetNamePath = "Assets/AssetBundle/" + AppConst.GameConfig + assetName + ".txt";
        //     var asset = LoadAsset(assetNamePath, typeof(TextAsset));
        //     if (asset == null) return null;
        //     var go = asset.asset as TextAsset;
        //     return go == null ? null : System.Text.Encoding.UTF8.GetString(go.bytes);
        // }

        // 加载 音频
        // public void LoadSoundAsync(string assetName, Action func)
        // {
        //     var assetNamePath = "Assets/AssetBundle/Sound/" + assetName;
        //     LoadAssetAsync(assetNamePath, typeof(AudioClip), (asset) =>
        //     {
        //         if (asset == null)
        //         {
        //             // func(null);
        //         }
        //         else
        //         {
        //             var go = GameObject.Instantiate(asset.asset) as AudioClip;
        //             // func(go);
        //         }
        //     });
        // }

        // public void LoadSoundAsync(string assetName, UnityAction func)
        // {
        //     var assetNamePath = "Assets/AssetBundle/Sound/" + assetName;
        //     LoadAssetAsync(assetNamePath, typeof(AudioClip), (asset) =>
        //     {
        //         if (asset == null)
        //         {
        //             // func.Call();
        //             func.Invoke();
        //         }
        //         else
        //         {
        //             var go = GameObject.Instantiate(asset.asset) as AudioClip;
        //             // func.Call(go);
        //         }
        //         // func.Dispose();
        //     });
        // }

        // public AudioClip LoadSound(string assetName)
        // {
        //     var assetNamePath = "Assets/AssetBundle/Sound/" + assetName;
        //     var asset = LoadAsset(assetNamePath, typeof(AudioClip));
        //     var go = asset?.asset as AudioClip;
        //     return go;
        // }
    
    }
}
