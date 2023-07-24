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
