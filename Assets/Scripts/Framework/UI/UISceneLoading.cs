using System;
using UnityEngine;
using UnityEngine.UI;

namespace YQFM
{
    public class UISceneLoading:MonoBehaviour
    {
        private bool m_bLoading;
        private Image m_bar;
        private xasset.Scene m_curScene;
        private void Start()
        {
            var obj = transform.Find("barBg/bar").gameObject;
            m_bar = obj.GetComponent<Image>();
        }

        private void Update()
        {
            if (m_bLoading)
            {
                float fillAmount = m_curScene.progress;
                m_bar.rectTransform.sizeDelta = new Vector2(550 * fillAmount,m_bar.rectTransform.sizeDelta.y);
            }
        }

        public void ExcuteLoading(xasset.Scene scene,ref Action<xasset.Scene> complete)
        {
            m_bLoading = true;
            m_curScene = scene;
            complete += scene1 =>
            {
                m_bLoading = false;
                gameObject.SetActive(false);
            };
        }
    }
}