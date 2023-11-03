using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        // eventTrigger.OnPointerClick += OnPointerClick;
        // eventTrigger.
        // eventTrigger.
    }


    void OnPointerClick(PointerEventData eventData)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
