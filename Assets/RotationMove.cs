using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMove : MonoBehaviour
{
    private Rigidbody m_rigid;

    private Vector3 curRot;

    private float m_rotZ;
    // Start is called before the first frame update
    void Start()
    {
        m_rigid = GetComponent<Rigidbody>();
        curRot = m_rigid.rotation.eulerAngles;
        m_rotZ = curRot.z;
    }

    // Update is called once per frame
    void Update()
    {
        m_rotZ += 20f * Time.deltaTime;
        m_rigid.rotation = Quaternion.Euler(curRot.x,curRot.y,m_rotZ );   
    }
}
