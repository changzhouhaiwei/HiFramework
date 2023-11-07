using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ImageTouchTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
        Debug.Log("点击");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
