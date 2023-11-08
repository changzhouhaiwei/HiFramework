using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YQFM
{
    // [only]
    public class UIBaseCanvas : UIBaseView
    {
        Canvas m_canvas;
        // Start is called before the first frame update
        protected override  void Start()
        {
            base.Start();
            Debug.Log("UIBaseCanvas Start");
            m_canvas = GetComponent<Canvas>();
        }

        void FixCanvas()
        {
            var rectTran = GetComponent<RectTransform>();
            rectTran.localScale = Vector3.one;
            
            //设置子界面扩展开
            rectTran.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, 0);
            rectTran.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0, 0);
            rectTran.anchorMin = Vector2.zero;
            rectTran.anchorMax = Vector2.one;
        }

        private void Awake()
        {
            FixCanvas();
        }

        protected void SetZorder()
        {
            
        }
        // Update is called once per frame
        void Update()
        {
            
        }


        public void BackUI()
        {
            UIManager.Inst.ReturnOneNode(this);
        }
    }
    
}
