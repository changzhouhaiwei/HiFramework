using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator Co1()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("co1");
        yield return new  WaitForEndOfFrame();
        Debug.Log("co1");
        yield return StartCoroutine(Co2());
        yield return null;
    }

    IEnumerator Co2()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Co2");
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(Co1());
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            TestGC();
        }
        
    }


    void TestGC()
    {
        Debug.Log("Test GC");
        var num = 10000;
        bool buseStr = false;

        for (int i = 0; i < num; i++)
        {
            if(!buseStr)
                StartCoroutine(GCFunc());
            else
            {
                StartCoroutine("GCFunc");
            }
        }
    }

    IEnumerator GCFunc()
    {
        yield return null;
    }
    
    
    
    private void FixedUpdate()
    {
        // if (Input.GetKeyDown(KeyCode.K))
        // {
        //     StartCoroutine(Co2());
        // }
    }
}
