using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedObj : MonoBehaviour,IRed
{
    public IRed Parent { get; set; }

    private Image _image;
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
    }

    public void UpdateRes(bool bRed)
    {
        if (Parent != null)
        {
            Parent.UpdateRes(bRed);
        }
        
        _image.color = bRed? Color.red : Color.white;

    }
}
