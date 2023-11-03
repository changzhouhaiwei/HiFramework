using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Threading;

public class TestThread : MonoBehaviour
{
    private int m_counter = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    void TestThreadExc()
    {
        for (int i = 0; i< 100000; i++)
        {
            m_counter += 2;
        }
        Debug.Log("counter=== " +  m_counter);
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TestThreadExc();
        }
    }
}
