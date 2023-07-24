using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace YQFM
{
    public class UIBaseView : MonoBehaviour
    {
        protected Dictionary<string, GameObject> m_uiInfo = new Dictionary<string, GameObject>();
        protected Dictionary<string, Component> m_compInfo = new Dictionary<string, Component>();
        protected void LoadUIInfo(Dictionary<string, string> dic)
        {
            foreach (var kv in dic)
            {
                var key = kv.Key;
                var value = kv.Value;

                var vArr = kv.Value.Split(new string[]{"=="},StringSplitOptions.None);
                if (vArr.Length > 0)
                {
                    var obj = m_uiInfo[key] = transform.Find(vArr[0]).gameObject;

                    if (vArr.Length >= 2)
                    {
                        string callbackName = vArr[1];
                        AddBtnClick(obj,callbackName);

                        if (vArr.Length >= 3)
                        {
                            string compName = vArr[2];
                            if (compName.Length > 0)
                            {
                                m_compInfo[key + "Comp"] = obj.GetComponent(compName);
                            }
                        }
                    }
                }               
                    
                    
            }
        }
        
        //TODO
        protected void AddBtnClick(GameObject btnObj,string callbackname)
        {
            Type myClassType = this.GetType();
            var methodInfo = myClassType.GetMethod(callbackname);
            if (methodInfo != null)
            {
                object[] parameters = new[] { btnObj };
                btnObj.GetComponent<Button>().onClick.AddListener(() => methodInfo.Invoke(this,parameters));
            }
        }

        public virtual void OnButtonClick(GameObject target)
        {
            
        }
        
        protected virtual void OnDestroy()
        {
            Debug.Log("UIBaseView OnDestroy");            
        }

        protected virtual void OnEnable()
        {
            Debug.Log("UIBaseView OnEnable");
        }

        protected virtual void OnDisable()
        {
            Debug.Log("UIBaseView OnDisable");
        }

        protected T GetComponentInKey<T>(string key)
        {
            return m_uiInfo[key].GetComponent<T>();
        }

        protected virtual void Start()
        {
            Debug.Log("virtural start");
        }

        protected Sprite LoadSprite(string path)
        {
            var asset =  ResMgr.Inst.LoadAsset(path, typeof(Texture2D));
            var tex = asset.asset as Texture2D;

            if (tex != null)
            {
                var sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.zero);
                return sprite;
            }

            return null;
        }
    }
    
}
