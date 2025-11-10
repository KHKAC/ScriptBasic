using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineDemo : MonoBehaviour
{
    IEnumerator m_Coroutine;
    bool isBreak;
    bool isCoroutineing;
    public static readonly WaitForSeconds wfs2f = new WaitForSeconds(2f);

    void Start()
    {
        m_Coroutine = CoroutineMethod();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(m_Coroutine);
        }

        if(isCoroutineing)
        {
            Debug.Log("코루틴이 실행되었거나 종료되었습니다.");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            //StopCoroutine(m_Coroutine);
            isBreak = true;
        }
        
        if(Input.GetKeyDown(KeyCode.C))
        {
            isBreak = false;
            m_Coroutine = CoroutineMethod();
            StartCoroutine(m_Coroutine);
            //StopAllCoroutines();
        }
    }
    
    IEnumerator CoroutineMethod()
    {
        
        int count = 0;
        while(true)
        {
            if (isBreak) break;
            Debug.Log(count);
            yield return new WaitForSeconds(1f);
            count++;
        }
        
        /*
        isCoroutineing = true;
        Debug.Log("Start");
        yield return new WaitForSeconds(1f);
        Debug.Log("End");
        isCoroutineing = false;
        */
    }
}
