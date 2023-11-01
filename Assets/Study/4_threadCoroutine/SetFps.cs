using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetFps : MonoBehaviour
{
    private float m_addTm;
    private int m_fps;

    private float m_fixAddTm;
    private int m_fixFps;
    
    [SerializeField]
    private TextMeshProUGUI m_txt1;
    
    [SerializeField]
    private TextMeshProUGUI m_txt2;

    // Start is called before the first frame update
    void Start()
    {
        m_addTm = 0f ;
        m_fps = 0;

        m_fixFps = 0;
        m_fixAddTm = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        m_addTm  +=  Time.deltaTime;
        m_fps ++ ;
        
        if (m_addTm >= 1.0f)
        {
            m_addTm -= 1.0f;
            m_txt1.text = "FPS:" + m_fps.ToString() + "___" + Time.deltaTime;
            m_fps = 0;
        }
    }

    private void FixedUpdate()
    {
        // m_fixAddTm += Time.fixedDeltaTime;
        // m_fixFps++;
        //
        // if (m_fixAddTm >= 1.0f)
        // {
        //     m_fixAddTm -= 1.0f;
        //     m_txt2.text = m_fixFps.ToString();
        //     m_fixFps = 0;
        //     Debug.Log("fixed -- " + Time.fixedDeltaTime);
        // }
        //
    }

    private void LateUpdate()
    {
        m_fixAddTm += Time.fixedDeltaTime;
        m_fixFps++;

        if (m_fixAddTm >= 1.0f)
        {
            m_fixAddTm -= 1.0f;
            m_txt2.text = m_fixFps.ToString();
            m_fixFps = 0;
            Debug.Log("fixed -- " + Time.fixedDeltaTime);
        }

    }

    private void OnGUI()
    {
        
    }
}
