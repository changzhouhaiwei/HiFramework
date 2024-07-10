using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuanernionTest : MonoBehaviour
{
    Vector3 vEularAng;

    private Vector3 vColL;
    
    private Quaternion m_rot;

    private double m_deg;
    // Start is called before the first frame update
    void Start()
    {
        m_rot = transform.rotation;
        vEularAng = transform.rotation.eulerAngles;
        vColL = new Vector3(1, 1, 0);

        var a1 = Vector3.right * -4;
        var a2 = Vector3.right;
        var j = Vector3.Dot(a1, a2);
        
        Debug.Log("jjjj " +j); 
        // Math.
    }

    // Update is called once per frame
    void Update()
    {
        // var deg = 0f;
        double x, y, z, w;
        x = Math.Sin(m_deg/2) * vColL.x;
        y = Math.Sin(m_deg/2) * vColL.y;
        z = Math.Sin(m_deg/2) * vColL.z;
        w = Math.Cos(m_deg/2);

        m_rot.x = (float)x;
        m_rot.y = (float)y;
        m_rot.z = (float)z;
        m_rot.w = (float)w;
        
        transform.rotation = m_rot;
        m_rot = transform.rotation;
        m_deg += 1f/180 * Math.PI;
    }
    
}
