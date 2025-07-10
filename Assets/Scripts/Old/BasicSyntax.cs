using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    void Start()
    {
        //이 행은 오브젝트의 x 위치를 나타냅니다.
        /*
        안녕하세요
        두줄로 구성된 주석입니다.
        */
        Debug.Log(transform.position.x);
        
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the gameObject");
        }
        if (transform.rotation.x < 4f)
        {
            
        }
    }

}
