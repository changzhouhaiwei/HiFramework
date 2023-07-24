using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAnimation : MonoBehaviour
{
    private Rigidbody m_rigid;

    public float speed = 1;

    private Vector3 m_initPos;
    private Vector3 m_dstPos;
    private Vector3 m_deltaPosNor;
    
    // Start is called before the first frame update
    void Start()
    {
        m_rigid = GetComponent<Rigidbody>();

        m_dstPos = new Vector3(0f, 0.8f, 2f);
        m_initPos = new Vector3(0f, 0.8f, 4f);
        // m_initPos = m_rigid.position;
        m_rigid.position = m_initPos;
        m_deltaPosNor = (m_dstPos - m_initPos).normalized;
        // m_deltaPos = m_dstPos;

        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while (true)
        {
            var d = Time.fixedDeltaTime* speed * m_deltaPosNor;
            m_rigid.position += d;

            if (m_rigid.position.z < 2f )
            {
                m_rigid.position =  new Vector3(0f,0.8f,2f);
                m_deltaPosNor *=  -1;
            } else if (m_rigid.position.z > 4f)
            {
                m_rigid.position =  new Vector3(0f,0.8f,4f);
                m_deltaPosNor *=  -1;
            }
            
            yield return new WaitForFixedUpdate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
