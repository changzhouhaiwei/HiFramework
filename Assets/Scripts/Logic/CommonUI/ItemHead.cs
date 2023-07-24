using UnityEngine;
using UnityEngine.UI;
using YQFM;

namespace Logic
{
    public class ItemHead : UIBaseView
    {
        private Button m_headBtn;

        protected override void Start()
        {
            base.Start();
        }

        public override void OnButtonClick(GameObject target)
        {
            if (target == m_headBtn.gameObject)
            {
                Debug.Log("点击了按钮" + target.name);
            }
        }
        
        protected override void OnDestroy()
        {
            base.OnDestroy();
            Debug.Log("itemHead OnDestroy");
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            Debug.Log("itemHead OnDisable");
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            Debug.Log("itemHead OnEnable");
        }
        
    }
}
