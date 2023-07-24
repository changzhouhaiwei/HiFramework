using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBall : MonoBehaviour
{
    public GameObject m_initObj1;

    public GameObject m_initObj2;

    public Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = m_initObj1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            var obj = GameObject.Instantiate(m_initObj1);
            obj.name = "newBall";
            obj.transform.position = initPos;
        }
    }
}
