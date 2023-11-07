using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageTouchTest : MonoBehaviour
{
    [SerializeField]
    private Button btn;
    // Start is called before the first frame update
    void Start()
    {
        AddEventToImage();
        AddCallbackToButton();
    }

    void AddEventToImage()
    {
        EventTrigger eventTrigger = gameObject.GetComponent<EventTrigger>();
        if (eventTrigger == null)
        {
            eventTrigger = gameObject.AddComponent<EventTrigger>();
        }

        EventTrigger.Entry enter = new EventTrigger.Entry();
        enter.eventID = EventTriggerType.PointerClick;
        enter.callback.AddListener(OnPointerClick);
        eventTrigger.triggers.Add(enter);
    }

    public void OnPointerClick(BaseEventData eventData)
    {
        Debug.Log("点击Image");
    }

    void AddCallbackToButton()
    {
        btn.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        Debug.Log("点击Button");
    }
    
    
    //TOTest
    //3D模型触摸和UI触摸的层级。
    // Update is called once per frame
    void Update()
    {
        
    }
}
